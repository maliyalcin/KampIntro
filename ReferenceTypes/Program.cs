using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "Ali", LastName = "Yalçın", City = "Ankara" };

            Customer customer2 = new Customer(3, "kemal", "yılmaz", "Samsun");

            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + customer.City);

            Console.WriteLine(customer2.FirstName + " " + customer2.LastName + " " + customer2.City);
        }
    }

    class Customer
    {
        public Customer()
        {

        }
        //default Constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Console.WriteLine("Yapıcı blok çalıştı");
        }


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
