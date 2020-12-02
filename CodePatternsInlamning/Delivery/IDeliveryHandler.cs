using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    // Responsible for distributing the order to the customer
    public interface IDeliveryHandler
    {
        void DeliverToCustomer();
    }
}