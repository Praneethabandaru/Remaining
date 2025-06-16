using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers
{
    public class BooksOnlineController : Controller
    {
        LMSdbEntities ob = new LMSdbEntities();
        // GET: BooksOnline
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Member m)
        {
            var user = ob.Members.FirstOrDefault(u => u.uname == m.uname && u.pwd == m.pwd);

            if (user != null)
            {
                Session["UserID"] = user.MemberID;  // Store user ID in session
                Session["Username"] = user.uname;  // Store username

                return RedirectToAction("Products");  // Redirect to Products page
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid username or password.";
                return View();
            }
        }

        public ActionResult Products(string searchTitle)
        {
            //if (Session["UserID"] == null) // Check if user is logged in
            //{
            //    return RedirectToAction("Login"); // Redirect to Login page
            //}
            //var res = from t in ob.Books
            //          select t;

            //return View(res.ToList());
            var books = ob.Books.AsQueryable();

            if (!string.IsNullOrEmpty(searchTitle))
            {
                books = books.Where(b => b.Title.Contains(searchTitle));
            }

            ViewBag.IsLoggedIn = Session["UserID"] != null;
            return View(books.ToList());
        }

        [HttpGet]
        public ActionResult Buy(int BookID)
        {
            var book = ob.Books.FirstOrDefault(b => b.BookID == BookID);
            if (book != null)
            {
                return View(book);  // Load book details
            }
            else
            {
                ViewBag.ErrorMessage = "Book not found!";
                return View();
            }
        }

        [HttpPost]
        public ActionResult Buy(int BookID, DateTime BorrowDate, DateTime DueDate)
        {
            var book = ob.Books.FirstOrDefault(b => b.BookID == BookID);
            if (book == null)
            {
                ViewBag.ErrorMessage = "Book not found!";
                return View();
            }

            // Save Borrow Transaction
            BorrowTransaction transaction = new BorrowTransaction
            {
                BookID = BookID,
                MemberID = Convert.ToInt32(Session["UserID"]),  // Get logged-in user
                BorrowDate = BorrowDate,
                DueDate = DueDate
            };

            ob.BorrowTransactions.Add(transaction);
            ob.SaveChanges();

            //return RedirectToAction("Return");  // Redirect after saving

            return RedirectToAction("Return", new { id = transaction.TransactionID });
        }


        [HttpGet]
        public ActionResult Register()
        {
                return View();
        }
        [HttpPost]
        public ActionResult Register(Member m)
        {
            var existingUser = ob.Members.FirstOrDefault(me => me.uname == m.uname);
            if (existingUser != null)
            {
                TempData["Message"] = "These user is already exists. please login ";
                return RedirectToAction("Login");
            }
            if (ModelState.IsValid)
            {
                ob.Members.Add(m);
                int i = ob.SaveChanges();
                return RedirectToAction("Login");

            }
            else
            {
                return View();
            }   
        }

        [HttpGet]
        public ActionResult Return(int id)
        {
            var transaction = ob.BorrowTransactions.Include("Book")
              .FirstOrDefault(t => t.TransactionID == id);

            if (transaction == null)
            {
                ViewBag.ErrorMessage = "Transaction not found!";
                return HttpNotFound();
            }

            return View(transaction);  // Display book details with borrow info
        }

        [HttpPost]
        public ActionResult Return(int TransactionID, DateTime ReturnDate)
        {
            var transaction = ob.BorrowTransactions.FirstOrDefault(t => t.TransactionID == TransactionID);

            if (transaction == null)
            {
                ViewBag.ErrorMessage = "Transaction not found!";
                return HttpNotFound();
            }

            // Update Return Date
            transaction.ReturnDate = ReturnDate;

            // Calculate Fine based on Due Date
            if (ReturnDate > transaction.DueDate)
            {
                int daysLate = (ReturnDate - transaction.DueDate).Days;
                transaction.fine = daysLate * 100;  // Example fine: ₹100 per overdue day
            }
            else
            {
                transaction.fine = 0;  // No fine if returned on time
            }

            ob.SaveChanges();  // Save updates in the database

            ViewBag.SuccessMessage = "Book returned successfully!";
            return View(transaction);
        }

        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login");
        }
        
        
    }
}