using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace EFCoreMusicianDemo {
    public class Program {

        static void Main(string[] args) {
            using (var db = new MusicolaDbContext(Environment.GetEnvironmentVariable("___TODO__POPULATE__THIS__"))) {
                db.AddLogging();
                db.Database.EnsureCreated();
                var axlRose = new Musician { SocialSecurityNumber = "AB1661", Name = "Axl Rose" };
                var slash = new Musician { SocialSecurityNumber = "HG6616", Name = "Slash" };
                var gunsNRoses = new Band() {
                    Name = "Guns n' Roses",
                    Members = { axlRose, slash }
                };
                db.Bands.Add(gunsNRoses);
                db.SaveChanges();
                foreach (var band in db.Bands) {
                    Console.WriteLine(band.Name);
                }
            }
            Console.ReadKey(false);
        }
    }

    public class MusicolaDbContext : DbContext {

        public DbSet<Band> Bands { get; set; }
        public DbSet<Musician> Musicians { get; set; }
        private readonly string connectionString;
        public MusicolaDbContext(string connectionString) {
            this.connectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            // Musician is modelled here using the Fluent API
            modelBuilder.Entity<Musician>().ToTable("Musician").HasKey(m => m.SocialSecurityNumber);
        }

        public void AddLogging() {
            var provider = this.GetInfrastructure<IServiceProvider>();
            ILoggerFactory loggerFactory = provider.GetService<ILoggerFactory>();
            loggerFactory.AddConsole(LogLevel.Information);
        }
    }

    // The Band in this example is mapped using System.ComponentModel.DataAnnotations
    [Table("Band")]
    public class Band {
        public Guid Id { get; set; } = Guid.NewGuid();

        [MaxLength(128)]
        public string Name { get; set; }

        public List<Musician> Members { get; set; } = new List<Musician>();
    }

    public class Musician {
        public string SocialSecurityNumber { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    public class Album {
        public string RecordLabel { get; set; }
        public string CatalogueNumber { get; set; }
        
        public decimal ListPrice { get; set; }
        public Band Band { get; set; }
        public string Title { get; set; }
        public int YearOfRelease { get; set; }
    }

    public class AlbumConfiguration : IEntityTypeConfiguration<Album> {
        public void Configure(EntityTypeBuilder<Album> builder) {
            builder.ToTable("Album").HasKey(nameof(Album.RecordLabel), nameof(Album.CatalogueNumber));
            builder.Property(album => album.Title).HasMaxLength(120).IsUnicode(false);
            builder.Property(album => album.ListPrice).HasColumnType("money");
        }
    }
}

