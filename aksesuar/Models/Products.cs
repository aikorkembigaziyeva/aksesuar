using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aksesuar.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name ="Ürün adı")]
        public string? ProductName { get; set; } = string.Empty;
        [Display(Name = "Ürün kodu")]
        public int? ProductCode { get; set; }
        [Display(Name = "Ürün açıklaması")]
        public string? ProductDescription { get; set; }  =string.Empty;
        [Display(Name = "Ürün resmi")]
        public string? ProductPicture { get; set; }
        [Display(Name = "Ürün fiyatı")]
        public int? ProductPrice { get; set; }
        [Display(Name = "Ürün kategorisi")]
        public int? CateoryId { get; set; }
        virtual public Category? Category { get; set; }
        [NotMapped] 
        public IFormFile? ImageUpload { get; set;}


    }
}
