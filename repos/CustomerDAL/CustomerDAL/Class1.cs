using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDAL
{
    public interface ICustomerRepository
    {
        int Insertdata(ProCustomer pc);
        ProCustomer FindByID(int CustomerId);
        int Deletedata(int id);

    }
    public class Class1 : ICustomerRepository
    {
        Model1Container mc = new Model1Container();
        ProCustomer pc = new ProCustomer();
        public int Insertdata(ProCustomer pc)
        {
             mc.ProCustomers.Add(pc);
             return mc.SaveChanges();
        }

        public ProCustomer FindByID(int CustomerId)
        {
            return mc.ProCustomers.Find(CustomerId);
        }

        public int Deletedata(int id)
        {
            var customer = mc.ProCustomers.Find(id); // Locate customer by ID
            if (customer != null)
            {
                mc.ProCustomers.Remove(customer); // Remove the found record
                return mc.SaveChanges(); // Commit deletion
            }
            return 0; // If customer wasn't found, return 0
        }

        public List<ProCustomer> ViewCustomers()
        {
            return mc.ProCustomers.ToList();
        }

        public List<ProCustomer> Search(string searchQuery)
        {
            return mc.ProCustomers
                .Where(m => m.CustomerId.ToString().Contains(searchQuery) ||
                            m.Name.Contains(searchQuery) ||
                            m.Email.Contains(searchQuery) ||
                            m.Mobile.Contains(searchQuery) ||
                            m.Age.ToString().Contains(searchQuery) ||
                            m.CustomerType.ToString().Contains(searchQuery) ||
                            m.RegisteredOn.ToString().Contains(searchQuery))
                .ToList();
        } 




    }
}
