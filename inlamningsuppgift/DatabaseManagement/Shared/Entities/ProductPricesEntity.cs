
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Entities;

public class ProductPricesEntity {
    [Key]
    [StringLength(256)]
    [ForeignKey(nameof(ProductEntity))]
    public string ArticleNumber { get; set; } = null!;

    [Required]
    [Column(TypeName = "char(3)")]
    [ForeignKey(nameof(CurrencyEntity))]
    public string CurrencyISOCode { get; set; } = null!;

    [Required]
    [Column(TypeName = "money")]
    public decimal Price { get; set; }

    [Column(TypeName = "money")]
    public decimal PriceDiscounted { get; set; }

    [Column(TypeName = "money")]
    public decimal PriceLast30Days { get; set; }

    [Required]
    [StringLength(256)]
    public string Type { get; set; } = null!; //Single, bundle, etc

    [Required]
    public virtual ProductEntity Product { get; } = null!;
}