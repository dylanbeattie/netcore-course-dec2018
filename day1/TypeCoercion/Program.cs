using System;

namespace TypeCoercion
{
    class Program
    {
        static void Main(string[] args)
        {
            uint x = 10;
            ushort y = 20;
            ulong z = 456898989809890;

            var total = x + y + z;
            Console.WriteLine(total);
            Console.WriteLine(total.GetType());
            Console.WriteLine("Hello World!");
        }
    }
}
