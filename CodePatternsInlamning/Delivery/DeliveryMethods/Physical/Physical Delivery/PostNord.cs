using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    public class PostNord : IPhysicalDelivery
    {
        public double ShippingCost { get; set; } = 100;

        public void SendToCustomer(IOrder order)
        {
            Console.WriteLine(
                $"\nPhysical products in {order.OrderId} will be shipped with PostNord to {order.Customer.StreetAddress} ");
        }
    }
}