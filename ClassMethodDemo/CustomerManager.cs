using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added! :" + customer.Name);
        }

        public void Delete(Customer customer)
        {
            
            Console.WriteLine("Customer Deleting.");
            Console.WriteLine(customer.Name + " Deleted. ");
            Console.WriteLine("-------------------------------------");


        }

       
    }
}
