using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.EntityLayer.Entities
{
    public class OpeningHour
    {
        public int Id { get; set; }
        public int FooterContentId { get; set; }
        public FooterContent FooterContent { get; set; }

        public DayOfWeek DayOfWeek { get; set; }
        public bool IsClosed { get; set; } = false;

        public TimeSpan? OpenTime { get; set; }
        public TimeSpan? CloseTime { get; set; }
    }

}
