namespace BalticMarinasBuySellWS.Utilities
{
    public static class Queries
    {
        public const string GetAllSoldItems = "select * from sold_items";

        public const string GetAllSoldItemsByUserId = "select * from sold_items where UserId = @userId";

        public const string GetSoldItemById = "select * from sold_items where SoldItemId = @id";

        public const string DeleteSoldItemById = "delete from sold_items where SoldItemId = @id";

        public const string CreateSoldItem = "INSERT INTO sold_items (Title, Category, Price, MadeYear, Description, UserId)\n" +
                    "VALUES (@title, @category, @price, @madeYear, @description, @userId);";
    }
}
