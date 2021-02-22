using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer
            {
                City = "Ankara",
                FirstName = "Ali",
                LastName = "Yalçın",
                Id = 5
            };

            Console.WriteLine(customer.City + " " + customer.FirstName + " " + customer.LastName + " " + customer.Id);

            Customer customer2 = new Customer();
            customer2.City = "Malatya";
            customer2.FirstName = "Mehmet";
            customer2.LastName = "Yalçın";
            customer2.Id = 3;

            Console.WriteLine(customer2.City + " " + customer2.FirstName + " " + customer2.LastName + " " + customer2.Id);


            Console.ReadLine();
        }
    }
}
