using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İstanbul", "İzmir");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer {FirstName = "Atlas"},
                new Customer {FirstName = "Ozan"});

            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    //-------------------------------------------------------------------------------------------------------------//
    interface IProductDal : IRepository<Product>
    {
    }

    interface ICustomerDal : IRepository<Customer>
    {
    }

    interface IStudentDal : IRepository<Student>
    {
    }

    class Student : IEntity
    {
    }

    interface IEntity
    {
    }

    //where -> referans tip olmalı, IEntiy implemente etmeli, newlenebilir olmalı
    interface IRepository<T> where T : class, IEntity, new() 
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T product);
        void Delete(T product);
        void Update(T product);
    }

    class Product : IEntity
    {
    }

    class Customer : IEntity
    {
        public string FirstName { get; set; }
    }

    class ProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Customer product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer product)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer product)
        {
            throw new NotImplementedException();
        }
    }
}