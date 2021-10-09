using System;

namespace DecoratorPattern
{
    class TypesOfCoffeeDrinks
    {
        static void Main(string[] args)
        {
            //This is our component.
            IExpressoShot expresso = new ExpressoShot();
            Console.WriteLine(expresso.Name);
            Console.WriteLine("--------");
            Console.WriteLine(expresso.ShowIngredients());

            //These are our decorators.
            Latte latte = new Latte(expresso);
            Console.WriteLine($"\n{latte.Name}");
            Console.WriteLine("--------");
            //We changed the behavior of the component. Now it shows more ingredients.
            Console.WriteLine(latte.ShowIngredients());
            //We can add a new behavior.
            Console.WriteLine($"\nDescription:\n{latte.ShowDescription()}");

            //Another example.
            Americano americano = new Americano(expresso);
            Console.WriteLine($"\n{americano.Name}");
            Console.WriteLine("--------");
            Console.WriteLine(americano.ShowIngredients());
            Console.WriteLine($"\nPro Tip:\n{americano.ShowProTip()}");
        } 
    }
}
