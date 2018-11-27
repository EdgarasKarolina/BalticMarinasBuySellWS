namespace BalticMarinasBuySellWS.Utilities
{
    public static class Queries
    {
        public const string GetAllSoldItems = "select * from sold_items";

        public const string GetSoldItemById = "select * from sold_items where SoldItemId = @id";
    }
}
