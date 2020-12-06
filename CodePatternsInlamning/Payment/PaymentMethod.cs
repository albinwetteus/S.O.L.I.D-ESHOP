using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CodePatternsInlamning
{
    public class PaymentMethod : IPaymentMethod
    {
        public IPayment Swish(IOrder order, IDeliveryMethods deliveryMethods)
        {
            return new SwishPayment(order, deliveryMethods);
        }

        public IPayment Creditcard(IOrder order, long cardNumber, IDeliveryMethods deliveryMethods)
        {
            return new CardPayment(order, cardNumber, deliveryMethods);
        }

        public IPayment Invoice(IOrder order, IDeliveryMethods deliveryMethods)
        {
            return new InvoicePayment(order, deliveryMethods);
        }

        public IPayment Klarna(IOrder order, IDeliveryMethods deliveryMethods)
        {
            return new KlarnaPayment(order, deliveryMethods);
        }
    }
}