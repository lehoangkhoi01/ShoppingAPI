namespace ShoppingAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty; 
        public string Address { get; set; } = string.Empty;
        public double TotalPrice { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;

        public List<OrderDetail>? OrderDetails { get; set; }

    }
}
