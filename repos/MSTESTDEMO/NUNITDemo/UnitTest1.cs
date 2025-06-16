using MyClassLib;
using Bank;
using System.ComponentModel.DataAnnotations;
namespace NUNITDemo
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(2,3,5)] //provides test data 
        [TestCase(4, 6, 10)]
        public void Test1(int a,int b,int d)
        {
            MyClass ob = new MyClass();
            int c= ob.AddNums(a,b);

            //Assert.AreEqual(30, c); it is depricated older way 
            
            Assert.That(c, Is.EqualTo(d));
        }
        [Test,Ignore("no comments,relax")]
        public void Test2()
        {
            MyClass ob = new MyClass();
            int c = ob.Multiply(10, 20);
            Assert.That (c, Is.EqualTo(30));
        }
        [Test]
        public void Test3() 
        {
            MyClass ob = new MyClass();
           
            var ex = Assert.Throws<System.DivideByZeroException>(() => ob.Divide(10, 0));
        }
        [Test]
        [TestCase("madam",true)]
        [TestCase("hello",false)]
        [TestCase("",false)]
        [TestCase(null, false)]
        public void palindrome(string? a,bool expected)
        {
            MyClass ob = new MyClass();
            bool c = ob.IsPalindrome(a);
            Assert.That(c, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("Potti", 500, 1500)] // Expect balance to be 1500 after deposit
        public void BankAccount_Deposit_Test(string owner, decimal depositAmount, decimal expectedBalance)
        {
            BankAccount ob = new BankAccount(owner, 1000);  // Create account with initial balance

            ob.Deposit(depositAmount); // Perform deposit

            Assert.That(ob.Balance, Is.EqualTo(expectedBalance)); // Verify balance update
        }

        [Test]
        [TestCase("Praneetha",200,1000)]
        public void BankAccount_Withdrawal_Test(string owner, decimal amount, decimal expectedBalance)
        {
            BankAccount ob = new BankAccount(owner,1200);
            ob.Withdraw(amount);
            Assert.That(ob.Balance,Is.EqualTo(expectedBalance));
        }

        [Test]
        public void BankAccount_Withdrawbeyond_ThrowsException()
        {
            BankAccount ob = new BankAccount("Potti", 500); // Initial balance: 500

            var ex = Assert.Throws<InvalidOperationException>(() => ob.Withdraw(1000)); // Trying to withdraw more than balance
            Console.WriteLine(ex.Message);
        }

        [Test]
        [TestCase("2025-06-07", true)] // Known Saturday
        [TestCase("2025-06-06", false)] // Known Friday
        public void Checking_Day(string dateString, bool expected)
        {
            DateTime date = DateTime.Parse(dateString);  // Convert string to DateTime                     
            MyClass ob = new MyClass();
            bool result = ob.IsWeekend(date);
            Assert.That(result, Is.EqualTo(expected)); // Validate the result
        }

        [Test]
        [TestCase(14, true)]
        [TestCase(11,false)]
        [TestCase(12, true)]
        public void EvenOrOdd(int number,bool expected)
        {
            MyClass ob = new MyClass();
            bool res = ob.IsEven(number);
            Assert.That(res, Is.EqualTo(expected));
        }

        [Test]
        public void CheckAge()
        {
            MyClass ob = new MyClass();
            var ex = Assert.Throws<ArgumentException>(() => ob.CheckAge(17)); // Age < 18
            Assert.That(ex.Message, Is.EqualTo("Age must be 18 or older"));
            Console.WriteLine(ex.Message);
        }

    }
}
