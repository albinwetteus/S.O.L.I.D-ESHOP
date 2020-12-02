namespace CodePatternsInlamning
{
    // contains chosen deliverymethods

    public interface IDeliveryMethods
    {
        IPhysicalDelivery PhysicalDelivery { get; }
        IDigitalDelivery DigitalDelivery { get; }
    }
}