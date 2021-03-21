using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass childClass = new ChildClass("Product");
            childClass.Add();
        }
    }

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }

    class ChildClass : BaseClass
    {
        public ChildClass(string entity) : base(entity)
        {
        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }
}