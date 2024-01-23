using Microsoft.EntityFrameworkCore;
using Shared.Entities;

namespace Shared.Contexts {
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options) {
        public virtual DbSet<ProductEntity> Products { get; set; }
        public virtual DbSet<ProductPricesEntity> ProductPrices { get; set; }
        public virtual DbSet<CurrencyEntity> Currencies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<CurrencyEntity>()
                .HasIndex(x => x.Name)
                .IsUnique();
        }
    }

}
