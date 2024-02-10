
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Entities;

public class ReviewsEntity {

    [Key]
    public int Id { get; set; }

    [Required]
    public int CustomerId { get; set; }

    [Required]
    [Column(TypeName = "tinyint")]
    public int Rating { get; set; }

    [StringLength(256)]
    public string? Title { get; set; }

    [StringLength(4000)]
    public string? Content { get; set; }

    //public virtual ProductEntity Product { get; } = null!;
    public virtual ProductReviewEntity ProductReview { get; set; } = null!;

}
