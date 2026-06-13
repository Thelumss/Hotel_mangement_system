using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Hotel_mangement_system.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public int RoomId { get; set; }
        public int Guest_Id { get; set; }
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }
        public int NumOfGuests { get; set; }
        public bool bookingStatus { get; set; } = true;
        public DateOnly bookingDate { get; set; }

        [ForeignKey("RoomId")]
        [JsonIgnore]
        public virtual Room? Room { get; set; }

        [ForeignKey("Guest_Id")]
        [JsonIgnore]
        public virtual Guest? Guest { get; set; }

    }
}
