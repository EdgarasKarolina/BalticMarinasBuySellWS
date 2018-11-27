namespace BalticMarinasBuySellWS.Models
{
    public class SoldItem
    {
        public int SoldItemId { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string MadeYear { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
    }
}
