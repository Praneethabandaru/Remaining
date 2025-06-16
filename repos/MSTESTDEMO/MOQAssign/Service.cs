using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQAssign
{
    public interface ICalculator
    {
        int Add(int a, int b);
    }
    public class Service : ICalculator
    {
        public int Add(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
    public class Customer()
    {
        public int CustomerID { get; set; }

        public string Name { get; set; }
    }
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int id);
    }
    public class CustomerService 
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }
        public string GetCustomerName(int id)
        {
            var customer = _repo.GetCustomerById(id);
            return customer?.Name ?? "Unknown";
        }
    }
}
