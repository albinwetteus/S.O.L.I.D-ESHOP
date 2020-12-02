using System.Collections.Generic;

namespace CodePatternsInlamning
{
    // is a deliveryoption for digital products
    public interface IDigitalDelivery
    {
        void SendToCustomer(IOrder order);
    }
}