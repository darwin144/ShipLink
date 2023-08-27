// Models/OrderDetail.cs
using System;

namespace Client_Shiplink.Models.OrderDetails
{
    public class OrderDetail
    {
        public string? Package { get; set; } 
        public string?  Information { get; set; } 
        public string?  Delivery { get; set; } 
        public string? Number { get; set; } 
        public string? Image { get; set; } 
        public string? Location { get; set; } 
        public string? StatusDelivery { get; set; } 
        public DateTime? ShippedDate { get; set; } 
        public string? Name { get; set; } 
        public string? Size { get; set; } 
        public string? Weight { get; set; } 
    }
}
