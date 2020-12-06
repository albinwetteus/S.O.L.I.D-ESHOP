using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    public class KlarnaPayment : IPayment
    {
      
        private readonly IOrder _order;
        private readonly IDeliveryMethods _deliveryMethods;

        public KlarnaPayment(IOrder order, IDeliveryMethods delivery)
        {
            _order = order;
            _deliveryMethods = delivery;
        }

        public void PayTheOrder()
        {
            Console.WriteLine($"\nPaying through Klarna.");
            Console.WriteLine($" Cost of products: {_order.TotalSumOfOrder} kr");
            Console.WriteLine($" Shipping cost: {_deliveryMethods.PhysicalDelivery.ShippingCost} kr");
            Console.WriteLine(
                $" Total cost: {_deliveryMethods.PhysicalDelivery.ShippingCost + _order.TotalSumOfOrder} kr");
            _order.IsPaid = true;
        }
    
    }
}
