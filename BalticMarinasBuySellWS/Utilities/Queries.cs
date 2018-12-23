namespace BalticMarinasBuySellWS.Utilities
{
    public static class Queries
    {
        public const string GetAllSoldItems = "SELECT * FROM sold_items";

        public const string GetAllSoldItemsByUserId = "SELECT * FROM sold_items WHERE UserId = @userId";

        public const string GetSoldItemById = "SELECT * FROM sold_items WHERE SoldItemId = @id";

        public const string DeleteSoldItemById = "DELETE FROM sold_items WHERE SoldItemId = @id";

        public const string CreateSoldItem = "INSERT INTO sold_items (Title, Category, Price, MadeYear, Description, UserId)\n" +
                    "VALUES (@title, @category, @price, @madeYear, @description, @userId);";
    }
}
