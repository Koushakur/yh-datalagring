
using System.ComponentModel.DataAnnotations;

namespace Shared.Entities;

public class CategoriesEntity {

    [Key]
    public int Id { get; set; }

    public int? ParentCategoryId { get; set; }

    [Required]
    [StringLength(256)]
    public string Name { get; set; } = null!;

    public virtual ProductCategoryEntity Product { get; set; } = null!;
    //public virtual ICollection<ProductEntity> Product { get; } = null!;
    public virtual CategoriesEntity? ParentCategory { get; set; }

}
