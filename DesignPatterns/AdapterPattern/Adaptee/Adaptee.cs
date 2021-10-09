using System;

namespace AdapterPattern
{
    public class Adaptee : IAdaptee
    {
        public Adaptee() { 
        }

        public int SpecificRequest() => new Random().Next();
    }
}
