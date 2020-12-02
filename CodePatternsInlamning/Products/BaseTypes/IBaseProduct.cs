using System;

namespace CodePatternsInlamning
{
    public interface IBaseProduct
    {
        Guid ProductId { get; }
        string Title { get; set; }

        double Price { get; set; }
    }
}