using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using foodapp.entity;

namespace foodapp.webui.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        [Display(Name="Ürün Adı",Prompt="Ürün Adı")]
        public string Name { get; set; }
        [Display(Name="Ürün Fiyatı",Prompt="0 &#8378")]
        public double Price { get; set; }
        [Display(Name="Onaylı mı?",Prompt="Hayır")]
        public bool IsApproved { get; set; }
        [Display(Name="Kategori Numarası",Prompt="1")]
        public int CategoryId { get; set; }
        [Display(Name="Resim Url'si",Prompt="11.jpg")]
        public string ImageUrl { get; set; }
        public List<Category> SelectedCategories{get; set;}


    }
}