using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace CodePatternsInlamning
{
    //responsible for creating new instances
    public static class Factory
    {
        public static ICustomer CreateCustomer()
        {
            return new Customer();
        }

        public static IOrder CreateOrder(ICustomer customer)
        {
            return new Order(customer, CreateShoppingCartHandler());
        }

        private static IShoppingCartService CreateShoppingCartHandler()
        {
            return new ShoppingCartService();
        }

        public static IPaymentMethod ChoosePaymentMethod()
        {
            return new PaymentMethod();
        }

        public static IDeliveryMethods ChooseDeliveryMethods(IPhysicalDelivery physicalDeliveryMethod, IDigitalDelivery digitalDeliveryMethod)
        {
            return new DeliveryMethods(physicalDeliveryMethod, digitalDeliveryMethod);
        }

        public static IPhysicalDeliveryMethod ChoosePhysicalDeliveryMethod()
        {
            return new PhysicalDeliveryMethod();
        }
        
        public static IDigitalDeliveryMethod ChooseDigitalDeliveryMethod()
        {
            return new DigitalDeliveryMethod();
        }

        public static IDeliveryHandler CreateDeliveryHandler(IOrder order, IDeliveryMethods deliveryMethods)
        {
            return new DeliveryHandler(order, deliveryMethods, Factory.CreateOrderSummary(), Factory.CreateStockBalanceHandler());
        }

        private static IStockBalanceHandler CreateStockBalanceHandler()
        {
            return new StockBalanceHandler();
        }

        private static IOrderSummary CreateOrderSummary()
        {
            return new OrderSummary();
        }
    }
}