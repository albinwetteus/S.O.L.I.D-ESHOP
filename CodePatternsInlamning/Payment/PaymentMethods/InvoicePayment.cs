using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    public class InvoicePayment : IPayment
    {
        private readonly IDeliveryMethods _deliveryMethods;
        private readonly IOrder _order;


        public InvoicePayment(IOrder order, IDeliveryMethods delivery)
        {
            _order = order;
            _deliveryMethods = delivery;
        }

        public void PayTheOrder()
        {
            Console.WriteLine($"\nInvoice sent to {_order.Customer.Email}");
            Console.WriteLine($" Cost of products: {_order.TotalSumOfOrder} kr");
            Console.WriteLine($" Shipping cost: {_deliveryMethods.PhysicalDelivery.ShippingCost} kr");
            Console.WriteLine(
                $" Total cost: {_deliveryMethods.PhysicalDelivery.ShippingCost + _order.TotalSumOfOrder} kr");


            _order.IsPaid = true;
        }
    }
}