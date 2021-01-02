using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using foodapp.entity;

namespace foodapp.webui.Models
{
    public class CategoryModel
    {
        
        public int CategoryId { get; set; }
        [Display(Name="Kategori Adı",Prompt="Kategori Adı")]
        [Required(ErrorMessage="Kategori Adı girilmelidir.")]
        [StringLength(20,MinimumLength=4,ErrorMessage="Kategori Adı 4 ile 20 karakter arasında olmalıdır.")]
        public string Name { get; set; }
        [Display(Name="Kategori Resmi",Prompt="Kategori Resmi")]
        public string ImageUrl { get; set; }
        [Display(Name="Kategoriye ait ürünler")]
        public List<Product> ProductsInThisCategory{get; set;}
    }
}