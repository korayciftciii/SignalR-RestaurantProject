using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.DataTransferObject.DiscountDTO
{
   public class CreateDiscountDto
    {
        public string DiscountTitle { get; set; }
        public string Description { get; set; }
        public int PercentageOfDiscount { get; set; }
        public string ImageUrl { get; set; }
        public bool DiscountStatus { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(30); // Default to 30 days from now
    }
}
