using System;

namespace HelloLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1) {
                Console.WriteLine("You must supply some names!");
                return;
            }

            var j = 0;
            do {
                Console.WriteLine($"Hello, {args[j]}");
                j++;
            } while (j < args.Length);
        }
    }
}
