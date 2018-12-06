using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using System;

namespace AspNetMvcDemo.Data {
    public class AnimalDbContext : DbContext {

        public AnimalDbContext(DbContextOptions<AnimalDbContext> options) : base(options) {
            EnableLogging();
            
        }
        
        public DbSet<Animal> Animals { get; set; }

        // THIS REQUIRES:
        // install-package Microsoft.Extensions.DependencyInjection
        // install-package Microsoft.Extensions.Logging.Console
        public void EnableLogging() {
            ILoggerFactory factory = this.GetService<ILoggerFactory>();
            factory.AddConsole(LogLevel.Information);
        }
    }
}
