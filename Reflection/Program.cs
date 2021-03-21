using System;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // DortIslem dortIslem = new DortIslem(2, 3);
            // Console.WriteLine(dortIslem.Topla(4, 3));
            // Console.WriteLine(dortIslem.Topla2());

            var type = typeof(DortIslem);

            // DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type, 5, 8);
            // Console.WriteLine(dortIslem.Topla(4, 5));
            // Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(type, 6, 7);
            Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));

            var metodlar = type.GetMethods();
            foreach (var info in metodlar)
            {
                Console.WriteLine("Metod adı : {0}", info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parameter : {0}", parameterInfo.Name);
                }
            }
        }
    }

    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }
}