using System;

namespace BitMaskPizza
{
    [Flags]
    enum PizzaToppings {
        Plain = 0,
        Cheese = 1,
        Tomato = 2,
        Olives =4,
        Bacon = 8,
        Anchovies = 16,
        Egg = 32,
        Pepperoni = 64,
        Mushroom = 128
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            var meat = PizzaToppings.Bacon | PizzaToppings.Pepperoni;
            var salty = meat | PizzaToppings.Anchovies;

            for(var i = 0; i < 256; i++) {
                var pizza = (PizzaToppings)i;
                var isSalty = (pizza & salty) > 0;
                if (isSalty) continue;
                Console.WriteLine($"Number {i} Special! ({(PizzaToppings)i})");
            }
            // var Hernando = (PizzaToppings) (
            //     PizzaToppings.Cheese
            //     |
            //     PizzaToppings.Tomato
            //     |
            //     PizzaToppings.Olives            
            // );

            // var Mark = (PizzaToppings) 
            //     PizzaToppings.Olives | PizzaToppings.Capers | PizzaToppings.Anchovies
            // ;
            // Console.WriteLine((int)Hernando);
            // Console.WriteLine((int)Mark);


            
            Console.WriteLine("Hello World!");
        }
    }
}
