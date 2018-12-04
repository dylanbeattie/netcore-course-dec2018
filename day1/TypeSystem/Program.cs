using System;

namespace TypeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 1;
            Console.WriteLine(x.GetType());

            var y = 0.2;
            Console.WriteLine(y.GetType());

            var z = 0.3M;
            Console.WriteLine(z.GetType());

            var a = 0.3446237615F;
            Console.WriteLine(a.GetType());

            int b = 1;
            uint c = 2;

            var someMysteriousValue = 17334598798L;

            Console.WriteLine(Int32.MaxValue);
            if (someMysteriousValue > Int32.MaxValue) {
                Console.WriteLine("We can't turn that into an integer!");
            } else {
                int myInteger = (int) someMysteriousValue;
            }

            
            

            // float x = 0.99999F;
            // float y = 0.00001F;
            // Console.WriteLine(x.GetType());
            // Console.WriteLine(x+y);
            // // while (x >= 0) {
            //     Console.WriteLine(x += 1_000_000_000_000_000_000);
            // }

            // Console.WriteLine("Hello World!");
        }
    }
}
