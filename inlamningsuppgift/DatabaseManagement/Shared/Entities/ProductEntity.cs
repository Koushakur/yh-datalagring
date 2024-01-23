
using System.ComponentModel.DataAnnotations;

namespace Shared.Entities;

public class ProductEntity {

    [Key]
    [StringLength(256)]
    public string ArticleNumber { get; set; }

    public int? ThumbnailImageId { get; set; } = null!;

    [Required]
    [StringLength(256)]
    public string? Name { get; set; } = null!;

    [StringLength(256)]
    public string? Ingress { get; set; } = null!;

    [StringLength(4000)]
    public string Description { get; set; }

    public string? DetailedSpecs { get; set; } = null!;


    // Relations //

    public virtual ProductPricesEntity Price { get; set; }
}