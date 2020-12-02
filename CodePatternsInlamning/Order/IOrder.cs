using System;
using System.Collections.Generic;

namespace CodePatternsInlamning
{
    //the current shoppingsession for the customer

    public interface IOrder
    {
        Guid OrderId { get; }
        bool IsPaid { get; set; } 
        double TotalSumOfOrder { get; set; }
        ICustomer Customer { get;}
        List<IPhysicalProduct> PhysicalCart { get; set; }
        List<IDigitalProduct> DigitalCart { get; set; }

        void RemoveProductFromCart(IBaseProduct product);

        void AddProductToCart(IBaseProduct product);
        void CheckOut();


    }
}