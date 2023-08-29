// DummyData/DummyDataShipment.cs
using System;
using System.Collections.Generic;
using Client_Shiplink.Models.Address;

namespace Client_Shiplink.DummyDataAddress
{
    public static class DummyDataAddress
    {
        public static List<Address> GetDummyData()
        {
            return new List<Address>
            {
                new Address
                {
                    image = "../Assets/imgdashboard/usa-flag.png",
                    country = "USA",
                    name = "Alex Rodriguez",
                    street = "890 Elmridge Ave., Unit 7E, Lexington MA, 02421",
                    phone = "781-987-6543",
                    email = "alex.rodriguez@email.com",
                },
                new Address
                {
                    image = "../Assets/imgdashboard/usa-flag.png",
                    country = "USA",
                    name = "Alex Rodriguez",
                    street = "890 Elmridge Ave., Unit 7E, Lexington MA, 02421",
                    phone = "781-987-6543",
                    email = "alex.rodriguez@email.com",
                },
                new Address
                {
                    image = "../Assets/imgdashboard/usa-flag.png",
                    country = "USA",
                    name = "Alex Rodriguez",
                    street = "890 Elmridge Ave., Unit 7E, Lexington MA, 02421",
                    phone = "781-987-6543",
                    email = "alex.rodriguez@email.com",
                },
                new Address
                {
                    image = "../Assets/imgdashboard/usa-flag.png",
                    country = "USA",
                    name = "Alex Rodriguez",
                    street = "890 Elmridge Ave., Unit 7E, Lexington MA, 02421",
                    phone = "781-987-6543",
                    email = "alex.rodriguez@email.com",
                },
                new Address
                {
                    image = "../Assets/imgdashboard/usa-flag.png",
                    country = "USA",
                    name = "Alex Rodriguez",
                    street = "890 Elmridge Ave., Unit 7E, Lexington MA, 02421",
                    phone = "781-987-6543",
                    email = "alex.rodriguez@email.com",
                },
                
                // ... tambahkan data dummy lainnya sesuai kebutuhan ...
            };
        }
    }
}
