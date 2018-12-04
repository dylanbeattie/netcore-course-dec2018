using System;

namespace FlowControlExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            if (x == 0) {
                // do something
            }

            var name = args[0];
            switch(name) {
                case "LouisXIV":
                case "HenryII":
                case "KingKong":
                case "ElizabethII":
                    Console.WriteLine("Hello, Your Majesty!");
                    break;
                case "ThePope":
                    Console.WriteLine("Hello, Your Holiness!");
                    break;
                default:
                    Console.WriteLine($"Hello, {name}");
                    break;
            }
        }
    }
}
