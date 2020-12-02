using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    public class DownloadlinkToEmail : IDigitalDelivery
    {
        public void SendToCustomer(IOrder order)
        {
            Console.WriteLine(
                $"\nDigital Products in {order.OrderId} will be sent with a downloadable link by email to {order.Customer.Email}: ");
        }
    }
}