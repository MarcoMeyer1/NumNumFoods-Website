using System.ComponentModel.DataAnnotations;

namespace NumNumFoods.Models
{
    public class ProductCreateRequest
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public int? CategoryId { get; set; } // Optional: Category ID for the product

        public string? StockStatus { get; set; } // Stock status of the product

        public string? ImageUrl { get; set; } // Make ImageUrl nullable
    }
}
