
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RentApp.Model;


namespace RentApp.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<TenantModel> Tenants { get; set; }
        public DbSet<FlatModel> Flats { get; set; }

        private readonly IConfiguration _config;

        public MyDbContext(DbContextOptions<MyDbContext> options, IConfiguration config)
            : base(options)
        {
            _config = config;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TenantModel>()
                .HasOne(p => p.Flat)
                .WithMany(p => p.Tenants)
                .HasForeignKey(p => p.flats_id);
        }
    }
}


