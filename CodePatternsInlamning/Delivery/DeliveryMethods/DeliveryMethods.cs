using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    // contains chosen deliverymethods

    public class DeliveryMethods : IDeliveryMethods
    {
        public IPhysicalDelivery PhysicalDelivery { get; }
        public IDigitalDelivery DigitalDelivery { get; }

        public DeliveryMethods(IPhysicalDelivery physicalDeliveryMethod, IDigitalDelivery digitalDeliveryMethod)
        {
            DigitalDelivery = digitalDeliveryMethod;
            PhysicalDelivery = physicalDeliveryMethod;
        }
    }
}