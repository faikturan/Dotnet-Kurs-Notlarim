using System;

namespace AdoNetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDal productDal = new ProductDal();
            
            /*var productList = productDal.GetAll();
            foreach (var product in productList)
            {
                Console.WriteLine(product.Name);
            }*/

            /*Product ampul = new Product
            {
                Name = "Kitap",
                UnitPrice = 15,
                StockAmount = 20
            };
            
            productDal.Add(ampul);*/

        }
    }
}