using System;

namespace TrinaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = args[0];
            string greeting = (name == "KingKong" ? "Your Majesty" : name);
            
            Console.WriteLine($"Hello {name}!");
        }
    }
}
