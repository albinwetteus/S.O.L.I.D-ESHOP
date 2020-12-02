namespace CodePatternsInlamning
{
    public interface ITeleVision : IPhysicalProduct
    {
        int ScreenSizeInInches { get; set; }
        string Brand { get; set; }
    }
}