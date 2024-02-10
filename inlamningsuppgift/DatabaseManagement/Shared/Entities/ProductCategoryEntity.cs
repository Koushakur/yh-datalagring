
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Entities;

public class ProductCategoryEntity {

    [Required]
    [StringLength(256)]
    [ForeignKey(nameof(ProductEntity))]
    public string ArticleNumber { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(CategoriesEntity))]
    public int CategoryId { get; set; }

    public virtual ProductEntity Product { get; } = null!;
    public virtual CategoriesEntity Category { get; } = null!;
}
