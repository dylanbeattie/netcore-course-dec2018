using Microsoft.EntityFrameworkCore;

namespace EFDemo1.DataModel {
    public class AnimalDbContext : DbContext {

        const string CONNECTION_STRING = @"__SECRET__";

        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }
    }
}
