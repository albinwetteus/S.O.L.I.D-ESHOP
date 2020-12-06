using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    // Contains all  payment methods
    public interface IPaymentMethod
    {
        IPayment Swish(IOrder order, IDeliveryMethods deliveryMethods);
        IPayment Creditcard(IOrder order, long cardNumber, IDeliveryMethods deliveryMethods);
        IPayment Invoice(IOrder order, IDeliveryMethods deliveryMethods);
        IPayment Klarna(IOrder order, IDeliveryMethods deliveryMethods);
    }
}