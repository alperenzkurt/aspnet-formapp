using System.ComponentModel.DataAnnotations;

namespace aspnet_formapp.Models
{
    public class Product
    {
        [Display(Name="Urun Id")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name="Urun Adi")]
        public string? Name { get; set; }
        
        [Required]
        [Range(0,10000)]
        [Display(Name="Fiyat")]
        public decimal? Price { get; set; }
        
        [Display(Name="Urun Fotografi")]
        public string? Image { get; set; }
        
        public bool IsActive { get; set; }
        
        [Required]
        [Display(Name="Kategori")]
        public int? CategoryId { get; set; }
    }
}
