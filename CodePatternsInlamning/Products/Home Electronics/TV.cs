using System;

namespace CodePatternsInlamning
{
    public class TV : ITeleVision
    {
        public Guid ProductId { get; } = Guid.NewGuid();
        public string Title { get; set; }
        public double Price { get; set; }
        public string Brand { get; set; }
        public int StorageAmount { get; set; } = 4;
        public int ScreenSizeInInches { get; set; }

        public TV(string title, string brand, double price, int storageAmount, int screenSizeInInches)
        {
            Title = title;
            Brand = brand;
            StorageAmount = storageAmount;
            ScreenSizeInInches = screenSizeInInches;
            Price = price;
        }
    }
}