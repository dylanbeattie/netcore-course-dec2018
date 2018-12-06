using AspNetMvcDemo.Data;
using System;

namespace AspNetMvcDemo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AnimalDbContext()) {
                foreach(var animal in db.Animals) {
                    Console.WriteLine(animal);
                }
            }
            Console.ReadKey();
        }
    }
}
