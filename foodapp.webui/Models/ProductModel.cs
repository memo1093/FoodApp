using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using foodapp.entity;

namespace foodapp.webui.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        [Display(Name="Ürün Adı",Prompt="Ürün Adı")]
        [StringLength(50,MinimumLength=4,ErrorMessage="Ürün adı 4 ile 50 karakter arasında girilmelidir.")]
        [Required(ErrorMessage="Ürün adı girilmelidir.")]
        public string Name { get; set; }
        [Display(Name="Ürün Fiyatı (₺) ",Prompt="3.500")]
        [Required(ErrorMessage="Ürün Fiyatı girilmelidir.")]
        [DataType(DataType.Currency,ErrorMessage="Ürün fiyatı sayı tipinde olmalıdır.")]
        public double? Price { get; set; }
        [Display(Name="Onaylı mı?",Prompt="Hayır")]
        public bool IsApproved { get; set; }
        [Display(Name="Kategori Numarası",Prompt="1")]
        
       [Required(ErrorMessage="Kategori Mutlaka seçilmelidir.")]
        public int CategoryId { get; set; }
        [Display(Name="Resim Url'si",Prompt="11.jpg")]
        
        public string ImageUrl { get; set; }
        
        
        public List<Category> SelectedCategories{get; set;}


    }
}