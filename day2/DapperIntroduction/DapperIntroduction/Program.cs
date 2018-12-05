using System;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace DapperIntroduction {
    class Program {
        static string ReadConnectionString() {
            return (Environment.GetEnvironmentVariable("DOTNET_WORKSHOP_SQL_CONNECTION_STRING", EnvironmentVariableTarget.User));
        }

        static void Main(string[] args) {
            var connectionString = ReadConnectionString();
            var db = new AnimalDatabase(connectionString);
            
            var jinx = new Animal {
                Name = "Mr. Jinx",
                Weight = 4.2M,
                NumberOfLegs = 4,
                IsItCute = true,
            };
            var joey = db.ListAnimals().Single(a => a.Name == "Joey the Kangaroo");
            joey.IsItCute = true;
            db.SaveAnimal(joey);

            Console.ReadLine();
        }
    }
}
