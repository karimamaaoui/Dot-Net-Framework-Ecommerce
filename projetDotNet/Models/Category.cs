namespace projetDotNet.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; } =new List<Product>();

        public Category() { }
        public Category (string categoryName)
        {
            CategoryId ++;
            CategoryName = categoryName;
        }
    }
}
