namespace DecoratorPattern
{
    class ExpressoShot : IExpressoShot
    {
        public string Name => "Expresso Shot";

        public string ShowIngredients()
        {
            return "Expresso";
        }
    }
}
