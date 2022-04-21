﻿namespace ShoppingAPI.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }    
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Product? Product { get; set; }
        public int ProductId { get; set; }
        public Order? Order { get; set; }
        public int OrderId { get; set; }

    }
}
