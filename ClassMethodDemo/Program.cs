using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Muzaffer";
            customer1.SurName = "Senkal";
            customer1.Age = 25;


            Customer customer2 = new Customer();
            customer2.Name = "Berke";
            customer2.SurName = "Kırsallıoba";
            customer2.Age = 24;

            Customer customer3 = new Customer();
            customer3.Name = "Yağmur";
            customer3.SurName = "Ulaş";
            customer3.Age = 24;

            


            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name); ;
                Console.WriteLine(customer.SurName);
                Console.WriteLine(customer.Age);
                Console.WriteLine("-------------------------------------");

            }

            CustomerManager customerManager = new CustomerManager();

            //add.
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            Console.WriteLine("-------------------------------------");

            //delete.
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);


        }
    }
}
