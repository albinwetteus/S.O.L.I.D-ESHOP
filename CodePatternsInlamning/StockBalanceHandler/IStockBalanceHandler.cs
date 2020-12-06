namespace CodePatternsInlamning
{
    public interface IStockBalanceHandler
    {
        void SubractFromStockBalance(IOrder order);
    }
}