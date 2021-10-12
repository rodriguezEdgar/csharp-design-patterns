using MediatorPattern.Medaitor;
using System;

namespace MediatorPattern.Colleagues
{
    public abstract class IColleague
    {
        IMediator _mediator;
        protected string _name;

        public IColleague(IMediator mediator, string name)
        {
            this._mediator = mediator;
            this._mediator.SignOn(Respond);
            this._name = name;
        }

        public abstract void Respond(string message, string from);

        public void Send(string message)
        {
            Console.WriteLine($"Send (from { this._name }): {message}");
            this._mediator.Send(message, this._name);
        }
    }

}

