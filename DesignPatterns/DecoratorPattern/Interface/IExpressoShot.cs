namespace DecoratorPattern
{
    public interface IExpressoShot
    {
        string Name { get; }

        /// <summary>
        /// Shows the ingredients of the drink
        /// </summary>
        /// <returns></returns>
        string ShowIngredients();
    }
}
