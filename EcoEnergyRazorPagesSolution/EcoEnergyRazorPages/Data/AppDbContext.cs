using EcoEnergyRazorPages.Model;
using Microsoft.EntityFrameworkCore;

namespace EcoEnergyRazorPages.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Simulation> Simulations { get; set; }
        /*public DbSet<WaterConsumption> WaterConsumptions { get; set; }
        public DbSet<EnergyIndicator> EnergyIndicators { get; set; }*/

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            string connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
