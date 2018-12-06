using Microsoft.EntityFrameworkCore;

namespace EFDemo1.DataModel {
    public class AnimalDbContext : DbContext {

        const string CONNECTION_STRING = @"Server=tcp:dnenivz721.database.windows.net,1433;Initial Catalog=workshop_dylan;Persist Security Info=False;User ID=workshop;Password=#o3Qq8s&xa!TBx4pmcdxZTV7;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }
    }
}
