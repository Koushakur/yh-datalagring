
using System.ComponentModel.DataAnnotations;

namespace Shared.Entities;

public class ProductEntity {

    [Key]
    [StringLength(256)]
    public string ArticleNumber { get; set; } = null!;

    public int? ThumbnailImageId { get; set; }

    [Required]
    [StringLength(256)]
    public string Name { get; set; } = null!;

    [StringLength(256)]
    public string? Ingress { get; set; }

    [StringLength(4000)]
    public string? Description { get; set; }

    public string? DetailedSpecsJSON { get; set; }


    // Relations //

    //public virtual CategoriesEntity Category { get; set; } = null!;
    public virtual ProductPricesEntity Price { get; set; } = null!;
    //public virtual ICollection<ReviewsEntity> Reviews { get; set; } = [];

    public virtual ProductCategoryEntity Category { get; set; } = null!;
    //public virtual CategoriesEntity Category { get; set; } = null!;
    public virtual ICollection<ProductReviewEntity> Reviews { get; set; } = null!;

    public virtual ICollection<ImagesEntity> Images { get; set; } = [];
    //public virtual ICollection<ProductImagesEntity> Images { get; set; } = null!;
}