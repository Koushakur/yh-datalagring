
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace Shared.Entities;

//public class ProductImagesEntity {

//    //[Key, Column(Order = 0)]
//    [Required]
//    [StringLength(256)]
//    //[ForeignKey(nameof(ProductEntity))]
//    public string ArticleNumber { get; set; } = null!;

//    //[Key, Column(Order = 1)]
//    [Required]
//    //[ForeignKey(nameof(ImagesEntity))]
//    public int ImageId { get; set; }

//    public virtual ProductEntity Product { get; } = null!;
//    public virtual ImagesEntity Image { get; } = null!;

//}
