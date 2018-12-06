using System;
using System.Linq;
using EFDemo1.DataModel;


namespace EFDemo1.ConsoleApp {
    class Program {
        static void Main(string[] args) {
            using (var db = new AnimalDbContext()) {
                db.Database.EnsureCreated();

                var lionel = db.Animals.Where(animal => animal.Name == "Lionel").First();
                while (true) {
                    var tunaFish = new TunaFish(400);
                    lionel.EatFood(tunaFish);
                    db.SaveChanges();

                    foreach (var item in db.Animals) {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("MOAR SNAX?");
                    Console.ReadKey();

                }
            }
        }
    }
}
