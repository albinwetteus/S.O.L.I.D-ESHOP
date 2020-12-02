namespace CodePatternsInlamning
{
    public interface IDigitalProduct : IBaseProduct
    {
        int DownloadsLeft { get; set; }
    }
}