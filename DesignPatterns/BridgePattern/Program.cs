using BridgePattern.Abstractions;
using BridgePattern.Bridges;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new Abstraction(new ImplementationA());
            Console.WriteLine($"Implementation A: { abstraction.Operation() }");

            abstraction = new Abstraction(new ImplementationB());
            Console.WriteLine($"Implementation B: { abstraction.Operation() }");
        }
    }
}
