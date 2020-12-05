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
        [Display(Name="Ürün Fiyatı (₺) ",Prompt="3.50")]
        [Required(ErrorMessage="Ürün Fiyatı girilmelidir.")]
        [Range(0.50,10000,ErrorMessage="0.50 ile 10.000 arasında bir değer girilmelidir.")]
        public double? Price { get; set; }
        [Display(Name="Onaylı mı?",Prompt="Hayır")]
        public bool IsApproved { get; set; }
        [Display(Name="Kategori Numarası",Prompt="1")]
        
        public int CategoryId { get; set; }
        [Display(Name="Resim Url'si",Prompt="11.jpg")]
        [Required(ErrorMessage="Resim Url'si girilmelidir.")]
        public string ImageUrl { get; set; }
        public List<Category> SelectedCategories{get; set;}


    }
}