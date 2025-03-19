using System.ComponentModel.DataAnnotations;

namespace InternetShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? Author { get; set; }
        [Required]
        [Range (1, int.MaxValue)]
        public double Price { get; set; }
    }
}
