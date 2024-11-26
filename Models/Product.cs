using System.ComponentModel.DataAnnotations;

namespace NumNumFoods.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public int? CategoryId { get; set; }

        public string StockStatus { get; set; }

        public string ImageUrl { get; set; }

        public string? CategoryName { get; set; } 
    }

    public class ProductCategory
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string AgeRange { get; set; }

        public string ContainerSize { get; set; }
    }
}
