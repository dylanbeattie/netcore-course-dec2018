// Modify the program so that:
// If you run it as dotnet run Chris
// It will print Hello, Chris

// If you don't, it'll prompt you for a name
// and then use that name - Hello {Name}
using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;            
            if (args.Length < 1) {
                Console.WriteLine("Please enter your name:");
                name = Console.ReadLine();
            } else {
                name = args[0];
            }
            Console.WriteLine($"Hello {name}");
        }
    }
}
