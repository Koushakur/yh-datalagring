
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Entities;

public class ImagesEntity {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string ContentURL { get; set; } = null!;

    public virtual ICollection<ProductEntity> Products { get; } = [];
    //public virtual ICollection<ProductImagesEntity> ProductImagesEntities { get; set; } = null!;
}
