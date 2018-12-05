using System;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace AdoNetIntroduction {
    class Program {
        static string ReadConnectionString() {
            return (Environment.GetEnvironmentVariable("DOTNET_WORKSHOP_SQL_CONNECTION_STRING", EnvironmentVariableTarget.User));
        }

        static void Main(string[] args) {
            var connectionString = ReadConnectionString();
            var db = new AnimalDatabase(connectionString);

            foreach (var animal in db.ListAnimals().Where(a => a.Weight < 800)) {
                Console.WriteLine(animal.Name);
            }
            Console.ReadKey(false);
        }
    }
}
