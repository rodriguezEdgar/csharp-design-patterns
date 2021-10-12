using MediatorPattern.Medaitor;
using System;

namespace MediatorPattern.Colleagues
{
    public class User : IColleague
    {
        public User(IMediator mediator, string name) : base(mediator, name)
        {
        }

        public override void Respond(string message, string from)
        {
            if (from == this._name)
            {
                return;                        
            }

            Console.WriteLine($"{ this._name } received from { from }: {message}");
        }
    }
}

