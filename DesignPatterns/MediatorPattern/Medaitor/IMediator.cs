using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MediatorPattern.Medaitor.ConcreteMediator;

namespace MediatorPattern.Medaitor
{
    public interface IMediator
    {
        void SignOn(Callback method);
        void Send(String message, string from);
    }
}
