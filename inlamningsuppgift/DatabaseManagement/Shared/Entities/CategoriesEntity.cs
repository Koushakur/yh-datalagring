
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Entities;

public class CategoriesEntity {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [StringLength(256)]
    public string Name { get; set; } = null!;

    public int? ParentCategoryId { get; set; }

    public virtual ProductCategoryEntity Product { get; set; } = null!;
    //public virtual ICollection<ProductEntity> Product { get; } = null!;
    public virtual CategoriesEntity? ParentCategory { get; set; }

}
