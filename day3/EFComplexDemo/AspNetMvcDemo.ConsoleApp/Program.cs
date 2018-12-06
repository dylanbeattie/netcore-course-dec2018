using AspNetMvcDemo.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace AspNetMvcDemo.ConsoleApp {
    class Program {
        const string CONNECTION_STRING = @"Server=tcp:dnenivz721.database.windows.net,1433;Initial Catalog=workshop_dylan;Persist Security Info=False;User ID=workshop;Password=#o3Qq8s&xa!TBx4pmcdxZTV7;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        static void Main(string[] args) {
            var options = new DbContextOptionsBuilder<MusicLibDbContext>().UseSqlServer(CONNECTION_STRING).Options;

            using (var db = new MusicLibDbContext(options)) {
                db.Database.EnsureCreated();
                //var bono = new Musician { NationalInsuranceNumber = "AB12345D", Name = "Bono", DateOfBirth = new DateTime(1965, 5, 2) };
                //var edge = new Musician { NationalInsuranceNumber = "AB44321F", Name = "The Edge", DateOfBirth = new DateTime(1967, 2, 10) };
                //db.Musicians.Add(bono);
                //db.Musicians.Add(edge);
                //var bono = db.Musicians.Single(m => m.Name == "Bono");
                //var edge = db.Musicians.Single(m => m.Name == "The Edge");

                //var u2 = db.Bands.Single(b => b.Name == "U2");
                //bono.Join(u2);
                //edge.Join(u2);
                //db.SaveChanges();
                var dave = new Musician { NationalInsuranceNumber = "FF12345F", Name = "Dave Grohl", DateOfBirth = new DateTime(1970, 1, 1) };
                var fooFighters = new Band { Name = "Foo Fighters" };
                var qotsa = new Band { Name = "Queens of the Stone Age" };
                db.Musicians.Add(dave);

                dave.Join(fooFighters);
                dave.Join(qotsa);
                db.SaveChanges();

                var bands = db.Bands.ToList();
                var musicians = db.Musicians.ToList();
                foreach (var musician in db.Musicians
                    .Include(m => m.BandMemberships)) {
                    Console.WriteLine(musician);
                }
            }
            Console.ReadKey();
        }
    }
}
