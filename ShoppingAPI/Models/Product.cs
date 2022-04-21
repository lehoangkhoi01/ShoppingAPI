namespace ShoppingAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;

        public string ProductDescription { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
        public double Price { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
        



    }
}
