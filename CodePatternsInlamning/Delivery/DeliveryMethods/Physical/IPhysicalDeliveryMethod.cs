using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    // Contains the different delivery methods for physical products
    public interface IPhysicalDeliveryMethod
    {
        IPhysicalDelivery Dhl();
        IPhysicalDelivery PostNord();
    }
}