
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Entities;

public class CurrencyEntity {
    [Key]
    [Column(TypeName = "char(3)")]
    public string ISOCode { get; set; }

    [Required]
    [StringLength(256)]
    public string Name { get; set; }

    [Required]
    [Column(TypeName = "nchar(1)")]
    public string Symbol { get; set; }

    public ICollection<ProductPricesEntity> Prices { get; set; }
}