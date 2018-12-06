using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;

namespace AspNetMvcDemo.Data {
    public class MusicLibDbContext : DbContext {

        public MusicLibDbContext(DbContextOptions<MusicLibDbContext> options) : base(options) {
            EnableLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Musician>().ToTable("Musician").HasKey(m => m.NationalInsuranceNumber);

            modelBuilder.Entity<Musician>()
                .Property(musician => musician.NationalInsuranceNumber)
                .HasMaxLength(12)
                .IsUnicode(false);

            modelBuilder.Entity<Band>()
                .ToTable("Band")
                .Property(band => band.Name)
                .HasMaxLength(100);

            modelBuilder.Entity<BandMembership>()
                .ToTable("BandMembership")
                .HasKey(bm => new { bm.MusicianNationalInsuranceNumber, bm.BandId });
        }

        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Band> Bands { get; set; }

        public void EnableLogging() {
            ILoggerFactory factory = this.GetService<ILoggerFactory>();
            factory.AddConsole(LogLevel.Information);
        }
    }
}
