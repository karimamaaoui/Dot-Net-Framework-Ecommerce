using Microsoft.EntityFrameworkCore;

namespace projetDotNet.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        [Precision(16, 2)]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string ImageFileName { get; set; } = "";
        public DateTime CreatedAt { get; set; }

        public Product(string productName, decimal price, int categoryId, Category category, string image)
        {
            ProductName = productName;
            Price = price;
            CategoryId = categoryId;
            Category = category;
            ImageFileName= image;
            this.CreatedAt = DateTime.Now;

        }

        public Product() { }
    }
}
