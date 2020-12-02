using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    // Contains the different delivery methods for physical products
    public class PhysicalDeliveryMethod : IPhysicalDeliveryMethod
    {
        public IPhysicalDelivery Dhl()
        {
            return new Dhl();
        }

        public IPhysicalDelivery PostNord()
        {
            return new PostNord();
        }
    }
}