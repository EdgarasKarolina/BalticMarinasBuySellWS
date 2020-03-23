namespace BalticMarinasBuySellWS.Models
{
    public class SoldItem
    {
        internal int SoldItemId { get; set; }
        internal string Title { get; set; }
        internal string Category { get; set; }
        internal decimal Price { get; set; }
        internal string MadeYear { get; set; }
        internal string Description { get; set; }
        internal int UserId { get; set; }
    }
}
