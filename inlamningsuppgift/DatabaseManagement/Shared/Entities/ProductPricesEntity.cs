
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Entities;

public class ProductPricesEntity {
    [Key]
    [StringLength(256)]
    [ForeignKey(nameof(ProductEntity))]
    public string ArticleNumber { get; set; }

    [Required]
    [Column(TypeName = "char(3)")]
    [ForeignKey(nameof(CurrencyEntity))]
    public string CurrencyISOCode { get; set; }

    [Required]
    [Column(TypeName = "money")]
    public decimal Price { get; set; }

    [Column(TypeName = "money")]
    public decimal PriceDiscounted { get; set; }

    [Column(TypeName = "money")]
    public decimal PriceLast30Days { get; set; }

    [Required]
    [StringLength(256)]
    public string Type { get; set; } //Single, bundle, etc

    [Required]
    public virtual ProductEntity Product { get; }
}
//ArticleNumber nvarchar(256) [not null, pk, ref: > Products.ArticleNumber]
//CurrencyISOCode char(3)[not null, ref: > Currencies.ISOCode]
//  Price money[not null]
//  PriceDiscounted money
//  PriceLast30Days money
//  Type nvarchar(256) /* Single, bundle, etc */