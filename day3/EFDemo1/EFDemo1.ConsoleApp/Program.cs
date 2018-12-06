using System;
using EFDemo1.DataModel;


namespace EFDemo1.ConsoleApp {
    class Program {
        static void Main(string[] args) {
            using (var db = new AnimalDbContext()) {
                db.Database.EnsureCreated();
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
