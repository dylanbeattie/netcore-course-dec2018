using AspNetMvcDemo.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace AspNetMvcDemo.ConsoleApp {
    class Program {
        const string CONNECTION_STRING = @"Server=tcp:dnenivz721.database.windows.net,1433;Initial Catalog=workshop_dylan;Persist Security Info=False;User ID=workshop;Password=#o3Qq8s&xa!TBx4pmcdxZTV7;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        static void Main(string[] args) {
            var options = new DbContextOptionsBuilder<AnimalDbContext>().UseSqlServer(CONNECTION_STRING).Options;

            using (var db = new AnimalDbContext(options)) {
                foreach (var animal in db.Animals) {
                    Console.WriteLine(animal);
                }
            }
            Console.ReadKey();
        }
    }
}
