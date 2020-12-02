namespace CodePatternsInlamning
{
    public interface IClothes : IPhysicalProduct
    {
        string Material { get; set; }
        string Size { get; set; }
        string Brand { get; set; }
    }
}