
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Entities;

public class ProductReviewEntity {

    [Required]
    //[ForeignKey(nameof(ProductEntity))]
    public string ProductId { get; set; } = null!;

    [Required]
    //[ForeignKey(nameof(ReviewsEntity))]
    public int ReviewId { get; set; }

    public virtual ProductEntity Product { get; } = null!;
    public virtual ReviewsEntity Review { get; } = null!;
}