using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var adaptee = new Adaptee();
            var adapter = new Adapter(adaptee);

            Console.WriteLine(adapter.Request());
        }
    }
}
