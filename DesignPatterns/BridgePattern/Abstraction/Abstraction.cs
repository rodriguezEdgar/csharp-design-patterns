using BridgePattern.Bridges;

namespace BridgePattern.Abstractions
{
    public class Abstraction
    {
        IBridge _implementation;
        public Abstraction(IBridge implementation)
        {
            this._implementation = implementation;
        }

        public string Operation() => this._implementation.Operation();
    }
}
