using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "masa");
            dictionary.Add("computer", "bilgisayar");
            
            dictionary["glass"] = "cam";
            //Console.WriteLine(dictionary["glass"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("car"));
            Console.WriteLine(dictionary.ContainsKey("table"));
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer>
            {
                new Customer {Id = 1, FirstName = "Onur"}, new Customer {Id = 2, FirstName = "Atlas"}
            };

            var count = customers.Count;

            Console.WriteLine(count);

            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Ozan"
            };
            customers.Add(customer2);

            customers.AddRange(new Customer[2]
            {
                new Customer() {Id = 4, FirstName = "Yunus"},
                new Customer() {Id = 5, FirstName = "Aziz"}
            });


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList {"Ankara", "Adana", 3, 'A'};

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}