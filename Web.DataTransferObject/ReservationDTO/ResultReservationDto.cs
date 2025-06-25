using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.DataTransferObject.ReservationDTO
{
   public class ResultReservationDto
    {
        public int ReservationId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string UserMail { get; set; }
        public int NumberOfCustomer { get; set; }
        public DateTime ReservationDate { get; set; } = DateTime.Now;
    }
}
