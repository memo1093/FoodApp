using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using foodapp.entity;

namespace foodapp.webui.Models
{
    public class CategoryModel
    {
        
        public int CategoryId { get; set; }
        [Display(Name="Kategori Adı",Prompt="Kategori Adı")]
        public string Name { get; set; }
        [Display(Name="Kategori Resmi",Prompt="Kategori Resmi")]
        public string ImageUrl { get; set; }
        [Display(Name="Kategoriye ait ürünler")]
        public List<Product> Products{get; set;}
    }
}