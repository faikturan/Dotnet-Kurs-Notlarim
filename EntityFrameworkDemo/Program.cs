using System;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDal productDal = new ProductDal();

            // var list = productDal.GetAll().Where(p => p.Name.Contains("ap")).ToList();

            var list = productDal.GetByName("");
            
            foreach (var product in list)
            {
                Console.WriteLine(product.Name);
            }

            var productWithId1 = productDal.GetById(12);
            Console.WriteLine(productWithId1.Name);
        }
    }
}