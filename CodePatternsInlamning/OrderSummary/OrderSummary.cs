using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    public class OrderSummary : IOrderSummary
    {
        public void PrintOrderSummary(IOrder order)
        {
            Console.WriteLine($"\nSummary of your order with  number: {order.OrderId}:");
            int i = 1;
                foreach (var p in order.PhysicalCart)
            {
                Console.WriteLine($"    {i}. {p.Title}");
                i++;
            }

            foreach (var p in order.DigitalCart)
            {
                Console.WriteLine($"    {i}. {p.Title}");
                i++;
            }

        }
    }
}
