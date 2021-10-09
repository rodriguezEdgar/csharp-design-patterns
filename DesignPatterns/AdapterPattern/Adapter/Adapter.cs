namespace AdapterPattern
{
    public class Adapter : ITarget
    {
        IAdaptee _adaptee;
        public Adapter(IAdaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public string Request() => _adaptee.SpecificRequest().ToString();
    }
}
