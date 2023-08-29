// DummyData/DummyDataShipment.cs
using System;
using System.Collections.Generic;
using Client_Shiplink.Models.SavedBoxSizes;

namespace Client_Shiplink.DummyDataSaveBox
{
    public static class DummyDataSaveBox
    {
        public static List<SavedBoxSize> GetDummyData()
        {
            return new List<SavedBoxSize>
            {
                new SavedBoxSize
                {
                    Pict = "Photo Frame",
                    Size = "8x9x10",
                    Weight = "0.5",
                    Date = "8/22/2023",
                },
                new SavedBoxSize
                {
                    Pict = "Photo Frame",
                    Size = "8x9x10",
                    Weight = "0.5",
                    Date = "8/22/2023",
                },
                new SavedBoxSize
                {
                    Pict = "Photo Frame",
                    Size = "8x9x10",
                    Weight = "0.5",
                    Date = "8/22/2023",
                },
                new SavedBoxSize
                {
                    Pict = "Photo Frame",
                    Size = "8x9x10",
                    Weight = "0.5",
                    Date = "8/22/2023",
                },
                new SavedBoxSize
                {
                    Pict = "Photo Frame",
                    Size = "8x9x10",
                    Weight = "0.5",
                    Date = "8/22/2023",
                },
                new SavedBoxSize
                {
                    Pict = "Photo Frame",
                    Size = "8x9x10",
                    Weight = "0.5",
                    Date = "8/22/2023",
                },
                // ... tambahkan data dummy lainnya sesuai kebutuhan ...
            };
        }
    }
}
