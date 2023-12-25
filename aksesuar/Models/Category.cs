using System.ComponentModel.DataAnnotations;

namespace aksesuar.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Display(Name = "Kategori adı")]
        [Required(ErrorMessage ="Bu alan boş bırakılmaz")]
        public string? CategoryName { get; set; }
        virtual public List<Products>? Products { get; set;}
    }
}
