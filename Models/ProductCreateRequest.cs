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

        public int? CategoryId { get; set; } 

        public string? StockStatus { get; set; } 

        public string? ImageUrl { get; set; } 
    }
}
