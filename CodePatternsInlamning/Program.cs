using System;
using System.Collections.Generic;


namespace CodePatternsInlamning
{
    static class Program
    {
        static void Main(string[] args)
        {
            var inventory = CreateProductSamples();


            ICustomer customer = Factory.CreateCustomer();
            customer.FirstName = "Kenny";
            customer.LastName = "Bennysson";
            customer.Email = "a@w.se";
            customer.PhoneNumber = "0738123443";
            customer.StreetAddress = "Vägstigen 44";


            IOrder order = Factory.CreateOrder(customer);


            order.AddProductToCart(inventory[0]);
            order.AddProductToCart(inventory[1]);
            order.RemoveProductFromCart(inventory[1]);
            order.AddProductToCart(inventory[2]);
            order.AddProductToCart(inventory[1]);

            order.CheckOut();

            IDeliveryMethods deliveryMethods = Factory.ChooseDeliveryMethods(
                Factory.ChoosePhysicalDeliveryMethod().Dhl(),
                Factory.ChooseDigitalDeliveryMethod().DownloadlinkToEmail()
            );

            Factory.ChoosePaymentMethod()
                .Klarna(order, deliveryMethods)
                .PayTheOrder();


            IDeliveryHandler delivery = Factory.CreateDeliveryHandler(order, deliveryMethods);

            delivery.DeliverToCustomer();


            Console.ReadLine();
        }





        private static List<IBaseProduct> CreateProductSamples()
        {
            return new List<IBaseProduct>
            {
                new Jacket("Dunjacka", "FJällräven", 1999, 2, "Dun", "XL"),
                new TV("Z345", "LG", 9999, 4, 55),
                new DigitalMovie("E.T", 99, 91, "Steven Spielberg"),
            };
        }
    }
}