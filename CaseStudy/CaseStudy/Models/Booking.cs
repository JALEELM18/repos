using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Casestudy.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int EventID { get; set; }
        public int UserID { get; set; }
        public decimal? Booking_Amount { get; set; }
        public int Booking_User_Id { get; set; }
        public int Booking_NumberofTickets { get; set; }
        public decimal? Booking_Single_UnitPrice { get; set; }

    }
}
