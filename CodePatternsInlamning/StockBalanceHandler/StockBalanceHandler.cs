namespace CodePatternsInlamning
{
    public class StockBalanceHandler : IStockBalanceHandler
    {
        public void SubractFromStockBalance(IOrder order)
        {
            foreach (var product in order.PhysicalCart)
            {
                product.StorageAmount -= 1;
            }
        }
    }
}