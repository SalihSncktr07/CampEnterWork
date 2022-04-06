using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void Delete(Customer customer);
        List<Customer> GetAll();
    }
}
