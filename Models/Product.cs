using System.ComponentModel.DataAnnotations;

namespace aspnet_formapp.Models
{
    public class Product
    {
        [Display(Name="Urun Id")]
        public int ProductId { get; set; }
        [Display(Name="Urun Adi")]
        public string? Name { get; set; }
        [Display(Name="Fiyat")]
        public decimal Price { get; set; }
        [Display(Name="Urun Fotografi")]
        public string? Image { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
    }
}