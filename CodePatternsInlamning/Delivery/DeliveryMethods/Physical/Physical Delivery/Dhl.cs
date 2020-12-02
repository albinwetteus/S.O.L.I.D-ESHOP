using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    public class Dhl : IPhysicalDelivery
    {
        public double ShippingCost { get; set; } = 120;


        public void SendToCustomer(IOrder order)
        {
            Console.WriteLine(
                $"\nPhysical products in {order.OrderId} will be shipped with DHL to :{order.Customer.StreetAddress} ");
        }
    }
}