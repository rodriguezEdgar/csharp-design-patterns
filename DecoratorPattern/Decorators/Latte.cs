using System.Text;

namespace DecoratorPattern
{
    class Latte : IExpressoShot
    {
        IExpressoShot _expresso;

        public string Name => "Latte";

        public Latte(IExpressoShot expresso)
        {
            _expresso = expresso;
        }

        public string ShowIngredients()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(_expresso.ShowIngredients());
            sb.Append("Steamed Milk");
            return sb.ToString();
        }

        /// <summary>
        /// New behavior. Shows a description of the latte.
        /// </summary>
        /// <returns></returns>
        public string ShowDescription()
        {
            return "As the most popular coffee drink out there,\nthe latte is comprised of a shot of espresso and steamed milk with just a touch of foam.\nIt can be ordered plain or with a flavor shot of anything from vanilla to pumpkin spice.";
        }
    }
}
