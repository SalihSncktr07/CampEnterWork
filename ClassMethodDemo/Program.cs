using ClassMetotDemo;
using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    internal class Program
    {
        static ICustomerService _customerService;

        static void Main(string[] args)
        {
            _customerService = new CustomerManager(new CustomerDal());
            Console.WriteLine("Değişiklik almamış liste");
            WriteCustomersToConsole();

            _customerService.Add(new Customer { Id=1,Name="Engin",LastName="Demiroğ" });
            Console.WriteLine("\nEkleme sonrası liste");
            WriteCustomersToConsole();

            _customerService.Delete(_customerService.GetAll()[0]);
            Console.WriteLine("\nSilme sonrası liste");
            WriteCustomersToConsole();
        }

        private static void WriteCustomersToConsole()
        {
            foreach (var customer in _customerService.GetAll())
            {
                Console.WriteLine(customer.Name);
            }
        }
    }
}
