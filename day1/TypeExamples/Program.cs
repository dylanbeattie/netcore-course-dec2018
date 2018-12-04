using System;

namespace TypeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
             var location = "😀Майдан Незалежності";
             for(var i = 0; i < location.Length; i++) {
                 var c = location[i];
                 Console.WriteLine($"{c}  {c.GetType()}");
             }
             Console.WriteLine(location);
        }
    }
}
