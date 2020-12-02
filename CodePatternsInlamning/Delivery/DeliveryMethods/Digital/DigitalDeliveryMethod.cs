using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    // Contains the different delivery methods for digital products

    public class DigitalDeliveryMethod : IDigitalDeliveryMethod
    {
        public IDigitalDelivery DownloadlinkToEmail()
        {
            return new DownloadlinkToEmail();
        }
    }
}