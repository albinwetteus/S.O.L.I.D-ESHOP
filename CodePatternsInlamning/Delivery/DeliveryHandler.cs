using System;
using System.Collections.Generic;

namespace CodePatternsInlamning
{
    // Responsible for distributing the order to the customer

    public class DeliveryHandler : IDeliveryHandler
    {
        private readonly IOrder _order;
        private readonly IDeliveryMethods _deliveryMethods;
        private readonly IOrderSummary _orderSummary;
        private readonly IStockBalanceHandler _stockBalanceHandler;


        public DeliveryHandler(IOrder order, IDeliveryMethods deliveryMethods, IOrderSummary orderSummary, IStockBalanceHandler stockBalanceHandler)
        {
            _order = order;
            _deliveryMethods = deliveryMethods;
            _orderSummary = orderSummary;
            _stockBalanceHandler = stockBalanceHandler;
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

            _orderSummary.PrintOrderSummary(_order);
            _stockBalanceHandler.SubractFromStockBalance(_order);
        }
    }
}