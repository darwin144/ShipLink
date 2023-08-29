// DummyData/DummyDataShipment.cs
using System;
using System.Collections.Generic;
using Client_Shiplink.Models.SavedQuotes;

namespace Client_Shiplink.DummyDataSavedQuotes
{
    public static class DummyDataSavedQuotes
    {
        public static List<SavedQuote> GetDummyData()
        {
            return new List<SavedQuote>
            {
                new SavedQuote
                {
                    ShipmentDate = "2023-09-02",
                    FromAddress = "USA, New York",
                    FromName = "John Doe",
                    FromPhone = "123-456-7890 ",
                    FromEmail = "jhondoe@gmail.com",
                    FromStreet = "123 Main St, ADDR-001, 12345",
                    ToAddress = "Canada, Toronto",
                    ToName = "Jane Smith",
                    ToPhone = "987-654-3210 ",
                    ToEmail = "Janesmith@gmail.com",
                    ToStreet = "456 Elm St, ADDR-002, M1X 2Y3",
                    Pict ="Photo Frame",
                    Size ="8x9x10",
                    Weight = "0.5",
                    Parcel ="Canada Post Regular Parcel",
                    Day="4",
                    Total="123"
                },
                new SavedQuote
                {
                    ShipmentDate = "2023-09-02",
                    FromAddress = "USA, New York",
                    FromName = "John Doe",
                    FromPhone = "123-456-7890 ",
                    FromEmail = "jhondoe@gmail.com",
                    FromStreet = "123 Main St, ADDR-001, 12345",
                    ToAddress = "Canada, Toronto",
                    ToName = "Jane Smith",
                    ToPhone = "987-654-3210 ",
                    ToEmail = "Janesmith@gmail.com",
                    ToStreet = "456 Elm St, ADDR-002, M1X 2Y3",
                    Pict ="Photo Frame",
                    Size ="8x9x10",
                    Weight = "0.5",
                    Parcel ="Canada Post Regular Parcel",
                    Day="4",
                    Total="123"
                },
                new SavedQuote
                {
                    ShipmentDate = "2023-09-02",
                    FromAddress = "USA, New York",
                    FromName = "John Doe",
                    FromPhone = "123-456-7890 ",
                    FromEmail = "jhondoe@gmail.com",
                    FromStreet = "123 Main St, ADDR-001, 12345",
                    ToAddress = "Canada, Toronto",
                    ToName = "Jane Smith",
                    ToPhone = "987-654-3210 ",
                    ToEmail = "Janesmith@gmail.com",
                    ToStreet = "456 Elm St, ADDR-002, M1X 2Y3",
                    Pict ="Photo Frame",
                    Size ="8x9x10",
                    Weight = "0.5",
                    Parcel ="Canada Post Regular Parcel",
                    Day="4",
                    Total="123"
                },
                new SavedQuote
                {
                    ShipmentDate = "2023-09-02",
                    FromAddress = "USA, New York",
                    FromName = "John Doe",
                    FromPhone = "123-456-7890 ",
                    FromEmail = "jhondoe@gmail.com",
                    FromStreet = "123 Main St, ADDR-001, 12345",
                    ToAddress = "Canada, Toronto",
                    ToName = "Jane Smith",
                    ToPhone = "987-654-3210 ",
                    ToEmail = "Janesmith@gmail.com",
                    ToStreet = "456 Elm St, ADDR-002, M1X 2Y3",
                    Pict ="Photo Frame",
                    Size ="8x9x10",
                    Weight = "0.5",
                    Parcel ="Canada Post Regular Parcel",
                    Day="4",
                    Total="123"
                },
                
                // ... tambahkan data dummy lainnya sesuai kebutuhan ...
            };
        }
    }
}
