using MediatorPattern.Medaitor;
using MediatorPattern.Colleagues;
using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();

            IColleague admin1 = new UserAdmin(mediator, "Jhon");
            IColleague admin2 = new UserAdmin(mediator, "Lucy");
            IColleague user = new User(mediator, "David");

            admin1.Send("Meeting on Tuesday, please all ack");
            user.Send("ack");
            admin2.Send("ack");
        }
    }
}
