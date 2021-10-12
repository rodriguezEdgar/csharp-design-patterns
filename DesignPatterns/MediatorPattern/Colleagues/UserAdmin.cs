using MediatorPattern.Medaitor;
using System;

namespace MediatorPattern.Colleagues
{
    public class UserAdmin : IColleague
    {
        public UserAdmin(IMediator mediator, string name) : base(mediator, name)
        {
        }

        public override void Respond(string message, string from)
        {
            //Administrators see all messages, including theirs
            Console.WriteLine($"{ _name } received from { from }: {message}");
        }
    }
}

