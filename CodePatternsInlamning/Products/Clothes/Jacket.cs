using System;

namespace CodePatternsInlamning
{
    public class Jacket : IClothes
    {
        public Jacket(string title, string brand, double price, int storageAmount, string material, string size)
        {
            Title = title;
            Brand = brand;
            StorageAmount = storageAmount;
            Material = material;
            Size = size;
            Price = price;
        }

        public Guid ProductId { get; } = Guid.NewGuid();
        public string Title { get; set; }
        public double Price { get; set; }
        public string Brand { get; set; }
        public int StorageAmount { get; set; }
        public string Material { get; set; }
        public string Size { get; set; }
    }
}