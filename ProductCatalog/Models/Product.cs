using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, MinLength(3), MaxLength(80)]
        public string Name { get; set; } = string.Empty;

        [Required, MinLength(3), MaxLength(30)]
        public string Sku { get; set; } = string.Empty;

        [Range(1, 1_000_000)]
        [Precision(18, 2)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; } = DateTime.Today;

        [Range(1, int.MaxValue, ErrorMessage = "Select a valid category.")]
        public int CategoryId { get; set; }

        // Navigation
        public Category? Category { get; set; }
    }
}
