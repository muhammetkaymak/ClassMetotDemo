using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 101;
            customer1.CustomerName = "Muhammet";
            customer1.CustomerSurname = "Kaymak";
            customer1.CustomerPhone = "0111 111 11 11";

            Customer customer2 = new Customer();
            customer2.CustomerId = 102;
            customer2.CustomerName = "Mücahit";
            customer2.CustomerSurname = "Kaymak";
            customer2.CustomerPhone = "0222 222 22 22";

            List<Customer> customers = new List<Customer> { customer1, customer2 };
            CustomerManager customerManager = new CustomerManager();

            customerManager.CustomerAdd(customer1);

            foreach(Customer customer in customers) 
            {
                Console.WriteLine("---------------Müşteri---------------");
                Console.WriteLine("Müşteri Id : " + customer.CustomerId);
                Console.WriteLine("Müşteri Adı : " + customer.CustomerName);
                Console.WriteLine("Müşteri Soyadı : " + customer.CustomerSurname);
                Console.WriteLine("Müşteri Telefonu : " + customer.CustomerPhone);
                Console.WriteLine("");
            }
        }
    }
}
