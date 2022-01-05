using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine(customer.CustomerId + " : " + customer.CustomerName + " " + customer.CustomerSurname 
                + " adlı müşteri eklendi." );
        }

        public void CustomerDel(Customer customer)
        {
            Console.WriteLine(customer.CustomerId + " : " + customer.CustomerName + " " + customer.CustomerSurname
                + " adlı müşteri silindi.");
        }

        public void CustomerList(Customer customer)
        {
            Console.WriteLine("---------------Müşteri---------------");
            Console.WriteLine("Müşteri Id : " + customer.CustomerId);
            Console.WriteLine("Müşteri Adı : " + customer.CustomerName);
            Console.WriteLine("Müşteri Soyadı : " + customer.CustomerSurname);
            Console.WriteLine("Müşteri Telefonu : " + customer.CustomerPhone);
        }
    }
}
