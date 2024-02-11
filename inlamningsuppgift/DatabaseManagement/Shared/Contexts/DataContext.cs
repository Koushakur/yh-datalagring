using Microsoft.EntityFrameworkCore;
using Shared.Entities;

namespace Shared.Contexts {
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options) {
        public virtual DbSet<ProductEntity> Products { get; set; }
        public virtual DbSet<CurrencyEntity> Currencies { get; set; }
        public virtual DbSet<CategoriesEntity> Categories { get; set; }
        public virtual DbSet<ImagesEntity> Images { get; set; }
        public virtual DbSet<ReviewsEntity> Reviews { get; set; }
        public virtual DbSet<ProductPricesEntity> ProductPrices { get; set; }
        public virtual DbSet<ProductCategoryEntity> ProductCategory { get; set; }
        //public virtual DbSet<ProductImagesEntity> ProductImages { get; set; }
        public virtual DbSet<ProductReviewEntity> ProductReview { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<CurrencyEntity>()
                .HasIndex(c => c.Name)
                .IsUnique();

            modelBuilder.Entity<ImagesEntity>()
                .Property(i => i.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<CategoriesEntity>()
                .Property(i => i.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<ReviewsEntity>()
                .Property(i => i.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<ImagesEntity>()
                .HasIndex(i => i.ContentURL)
                .IsUnique();

            //modelBuilder.Entity<ProductImagesEntity>()
            //    .HasKey(nameof(ProductImagesEntity.ArticleNumber), nameof(ProductImagesEntity.ImageId));

            modelBuilder.Entity<ProductCategoryEntity>()
                .HasKey(nameof(ProductCategoryEntity.ArticleNumber), nameof(ProductCategoryEntity.CategoryId));

            modelBuilder.Entity<ProductReviewEntity>()
                .HasKey(nameof(ProductReviewEntity.ProductId), nameof(ProductReviewEntity.ReviewId));

        }
    }

}
