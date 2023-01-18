using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please entre a value")]
        public string Name { get; set; }

        public string Slug { get; set; }

        [Required, MinLength(4, ErrorMessage = "Minimum Length is 2")]
        public string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a value")]
        [Column(TypeName ="decimal(8,2)")]
        public Decimal Price { get; set; }

        public long CategoryId { get; set; }

        public Category Category { get; set; }

        public string Image { get; set; }
    }
}
