using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Medaitor
{
    public class ConcreteMediator:IMediator
    {
        //There's another way to implement this using an IEnumerable
        public delegate void Callback(string message, string sender);
        Callback respond;

        public void SignOn(Callback method) {
            respond += method;
        }

        public void Send(string message, string from)
        {
            respond(message, from);
            Console.WriteLine();
        }
    }
}
