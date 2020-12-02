using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    public class Bluray : IMovie, IPhysicalProduct
    {
        public int RunTimeInMinutes { get; set; }
        public string Director { get; set; }
        public Guid ProductId { get; } = Guid.NewGuid();
        public string Title { get; set; }
        public double Price { get; set; }
        public int StorageAmount { get; set; }
    }
}