// DummyData/DummyDataShipment.cs
using System;
using System.Collections.Generic;
using Client_Shiplink.Models.OrderDetails;

namespace Client_Shiplink.DummyDataOrder
{
    public static class DummyDataOrder
    {
        public static List<OrderDetail> GetDummyData()
        {
            return new List<OrderDetail>
            {
                new OrderDetail
                {
                    Package = "#5635-342801",
                    Information = "My Mailbox",
                    Delivery = "Express",
                    Number = "872812138321",
                    Image = "../Assets/imgdashboard/usa-flag.png",
                    Location = "Boston, USA",
                    StatusDelivery = "Ready To Pickup",
                    ShippedDate = new DateTime(2023, 6, 12),
                    Name = "Testing1",
                    Size = "12mm x 10mm",
                    Weight = "1kg"
                },
                new OrderDetail
                {
                    Package = "#5635-342801",
                    Information = "My Mailbox",
                    Delivery = "Express",
                    Number = "872812138322",
                    Image = "../Assets/imgdashboard/usa-flag.png",
                    Location = "Boston, USA",
                    StatusDelivery = "Recieved",
                    ShippedDate = new DateTime(2023, 6, 12),
                    Name = "Testing1",
                    Size = "12mm x 10mm",
                    Weight = "1kg"
                },
                new OrderDetail
                {
                    Package = "#5635-342801",
                    Information = "My Mailbox",
                    Delivery = "Express",
                    Number = "872812138323",
                    Image = "../Assets/imgdashboard/usa-flag.png",
                    Location = "Boston, USA",
                    StatusDelivery = "Transit",
                    ShippedDate = new DateTime(2023, 6, 12),
                    Name = "Testing1",
                    Size = "12mm x 10mm",
                    Weight = "1kg"
                },
                new OrderDetail
                {
                    Package = "#5635-342801",
                    Information = "My Shipment",
                    Delivery = "Express",
                    Number = "872812138324",
                    Image = "../Assets/imgdashboard/usa-flag.png",
                    Location = "Boston, USA",
                    StatusDelivery = "Ready To Pickup",
                    ShippedDate = new DateTime(2023, 6, 12),
                    Name = "Testing1",
                    Size = "12mm x 10mm",
                    Weight = "1kg"
                },
                new OrderDetail
                {
                    Package = "#5635-342801",
                    Information = "My Shipment",
                    Delivery = "Express",
                    Number = "872812138331",
                    Image = "../Assets/imgdashboard/usa-flag.png",
                    Location = "Boston, USA",
                    StatusDelivery = "Recieved",
                    ShippedDate = new DateTime(2023, 6, 12),
                    Name = "Testing1",
                    Size = "12mm x 10mm",
                    Weight = "1kg"
                },
                new OrderDetail
                {
                    Package = "#5635-342801",
                    Information = "My Shipment",
                    Delivery = "Express",
                    Number = "872812138332",
                    Image = "../Assets/imgdashboard/usa-flag.png",
                    Location = "Boston, USA",
                    StatusDelivery = "Transit",
                    ShippedDate = new DateTime(2023, 6, 12),
                    Name = "Testing1",
                    Size = "12mm x 10mm",
                    Weight = "1kg"
                },
                new OrderDetail
                {
                    Package = "#5635-342801",
                    Information = "My Shipment",
                    Delivery = "Express",
                    Number = "872812138333",
                    Image = "../Assets/imgdashboard/usa-flag.png",
                    Location = "Boston, USA",
                    StatusDelivery = "Ready To Pickup",
                    ShippedDate = new DateTime(2023, 6, 12),
                    Name = "Testing1",
                    Size = "12mm x 10mm",
                    Weight = "1kg"
                },
                new OrderDetail
                {
                    Package = "#5635-342801",
                    Information = "Shipping Mailbox",
                    Delivery = "Express",
                    Number = "872812138325",
                    Image = "../Assets/imgdashboard/usa-flag.png",
                    Location = "Boston, USA",
                    StatusDelivery = "Recieved",
                    ShippedDate = new DateTime(2023, 6, 12),
                    Name = "Testing1",
                    Size = "12mm x 10mm",
                    Weight = "1kg"
                },
                new OrderDetail
                {
                    Package = "#5635-342801",
                    Information = "My Mailbox",
                    Delivery = "Express",
                    Number = "872812138326",
                    Image = "../Assets/imgdashboard/usa-flag.png",
                    Location = "Boston, USA",
                    StatusDelivery = "Transit",
                    ShippedDate = new DateTime(2023, 6, 12),
                    Name = "Testing1",
                    Size = "12mm x 10mm",
                    Weight = "1kg"
                },
                // ... tambahkan data dummy lainnya sesuai kebutuhan ...
            };
        }
    }
}
