namespace FoodShop.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }

        public string Person { get; set; }

        public string Address { get; set; }

        public int FoodId { get; set; }

        public DateTime Date { get; set; }
    }
}
