using Microsoft.EntityFrameworkCore;

namespace projetDotNet.Models
{
    public class ProductDto
    {
        public string ProductName { get; set; }
        [Precision(16, 2)]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public IFormFile? ImageFileName { get; set; }


    }
}
