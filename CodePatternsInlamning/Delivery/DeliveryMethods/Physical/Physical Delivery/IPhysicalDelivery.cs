using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    // is a deliveryoption for physical products
    public interface IPhysicalDelivery
    {
        void SendToCustomer(IOrder order);
        double ShippingCost { get; set; }
    }
}