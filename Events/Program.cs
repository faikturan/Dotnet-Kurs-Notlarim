using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product hardDisk = new Product(50);
            hardDisk.ProductName = "Hard Disk";

            Product gsm = new Product(50);
            gsm.ProductName = "Telefon";
            gsm.StockControlEvent += GsmOnStockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                hardDisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }
        }

        private static void GsmOnStockControlEvent()
        {
            Console.WriteLine("Gsm about to finish!!");
        }
    }
}