using System;
using System.Collections.Generic;

namespace CodePatternsInlamning
{
    // Responsible for distributing the order to the customer

    public class DeliveryHandler : IDeliveryHandler
    {
        private readonly IOrder _order;
        private readonly IDeliveryMethods _deliveryMethods;


        public DeliveryHandler(IOrder order, IDeliveryMethods deliveryMethods)
        {
            _order = order;
            _deliveryMethods = deliveryMethods;
        }


        public void DeliverToCustomer()
        {
            if (_order.IsPaid == false)
            {
                Console.WriteLine("Order not paid ");
                return;
            }

            if (_order.PhysicalCart.Count != 0)
            {
                _deliveryMethods.PhysicalDelivery.SendToCustomer(_order);
            }

            if (_order.DigitalCart.Count != 0)
            {
                _deliveryMethods.DigitalDelivery.SendToCustomer(_order);
            }

            PrintOrderSummary();
            SubractFromStockBalance();
        }


        private void PrintOrderSummary()
        {
            Console.WriteLine($"\nSummary of your order with  number: {_order.OrderId}:");
            int i = 1;
            foreach (var p in _order.PhysicalCart)
            {
                Console.WriteLine($"    {i}. {p.Title}");
                i++;
            }

            foreach (var p in _order.DigitalCart)
            {
                Console.WriteLine($"    {i}. {p.Title}");
                i++;
            }
        }

        private void SubractFromStockBalance()
        {
            foreach (var product in _order.PhysicalCart)
            {
                product.StorageAmount -= 1;
            }
        }
    }
}