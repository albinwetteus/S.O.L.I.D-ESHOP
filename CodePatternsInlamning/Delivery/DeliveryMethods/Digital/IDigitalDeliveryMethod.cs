using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    // Contains the different delivery methods for digital products

    public interface IDigitalDeliveryMethod
    {
        IDigitalDelivery DownloadlinkToEmail();
    }
}