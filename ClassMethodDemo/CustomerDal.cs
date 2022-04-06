using System.Collections.Generic;

namespace ClassMetotDemo
{
    public class CustomerDal : ICustomerDal
    {
        List<Customer> _customers;

        public CustomerDal()
        {
            _customers = new List<Customer> {
                new Customer {Id=1,Name="Mustafa",LastName="Aktoz" },
                new Customer {Id=2,Name="Onur",LastName="Şimşek" },
                new Customer {Id=3,Name="Mehmet",LastName="Demir" },
            };
        }

        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        public List<Customer> GetAll()
        {
            return _customers;
        }

        public void Delete(Customer customer)
        {
            _customers.Remove(customer);
        }
    }
}
