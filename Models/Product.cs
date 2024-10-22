using System.ComponentModel.DataAnnotations;

namespace NumNumFoods.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; } // Ensure this property exists
        public string Name { get; set; } // Name of the product
        public string Description { get; set; } // Description of the product
        public decimal Price { get; set; } // Price of the product
        public int StockQuantity { get; set; } // Available stock quantity
        public string Location { get; set; } // Location where the product is available
    }

    public class ProductCategory
    {
        [Key]
        public int CategoryId { get; set; } // Unique identifier for the category

        [Required]
        public string Name { get; set; } // Name of the category

        public string AgeRange { get; set; } // Optional: Age range for products in this category

        public string ContainerSize { get; set; } // Optional: Size of the container for products in this category
    }
}
