using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    public class CardPayment : IPayment
    {
        private readonly IOrder _order;
        private long CardNumber { get; set; }
        private readonly IDeliveryMethods _deliveryMethods;


        public CardPayment(IOrder order, long cardNumber, IDeliveryMethods delivery)
        {
            CardNumber = cardNumber;
            _order = order;
            _deliveryMethods = delivery;
        }


        public void PayTheOrder()
        {
            Console.WriteLine($"\nDebited card with number: {CardNumber} ");
            Console.WriteLine($" Cost of products: {_order.TotalSumOfOrder} kr");
            Console.WriteLine($" Shipping cost: {_deliveryMethods.PhysicalDelivery.ShippingCost} kr");
            Console.WriteLine(
                $" Total cost: {_deliveryMethods.PhysicalDelivery.ShippingCost + _order.TotalSumOfOrder} kr");

            _order.IsPaid = true;
        }
    }
}