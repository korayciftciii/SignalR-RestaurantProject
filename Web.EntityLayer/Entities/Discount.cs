namespace Web.EntityLayer.Entities
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public string DiscountTitle { get; set; }
        public string Description { get; set; }
        public int PercentageOfDiscount { get; set; }
        public string ImageUrl { get; set; }
        public bool DiscountStatus { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(30); // Default to 30 days from now
    }
}
