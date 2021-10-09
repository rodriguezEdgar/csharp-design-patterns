using System.Text;

namespace DecoratorPattern
{
    class Americano : IExpressoShot
    {
        IExpressoShot _expresso;
        public string Name => "Americano";
        public Americano(IExpressoShot expresso)
        {
            this._expresso = expresso;
        }

        public string ShowIngredients()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(_expresso.ShowIngredients());
            sb.Append("Hot water");
            return sb.ToString();
        }

        /// <summary>
        /// New behavior. Shows a tip about making an Americano.
        /// </summary>
        /// <returns></returns>
        public string ShowProTip()
        {
            return "If you’re making your own, pour the espresso first, then add the hot water.";
        }
    }
}
