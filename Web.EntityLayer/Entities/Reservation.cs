namespace Web.EntityLayer.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string UserMail { get; set; }
        public int NumberOfCustomer { get; set; }
        public DateTime ReservationDate { get; set; } = DateTime.Now;
    }
}
