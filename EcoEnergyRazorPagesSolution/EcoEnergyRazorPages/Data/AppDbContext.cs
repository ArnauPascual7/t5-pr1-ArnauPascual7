using System.Diagnostics;
using EcoEnergyRazorPages.Model;
using EcoEnergyRazorPages.Tools;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace EcoEnergyRazorPages.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<DbSimulation> Simulations { get; set; }
        public DbSet<DbWaterConsumption> WaterConsumptions { get; set; }
        public DbSet<DbEnergyIndicator> EnergyIndicators { get; set; }

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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ModelBuilderHelper.Seed(modelBuilder);
        }
    }
}
