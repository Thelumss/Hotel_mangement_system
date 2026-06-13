using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Hotel_mangement_system.Models
{
    public class Room
    {
        [Key] 
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public float PricePerNight { get; set; }
        public int Capacity { get; set; }

        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
        public int RoomStatusId { get; set; }

        [ForeignKey("HotelId")]
        [JsonIgnore]
        public virtual Hotel? Hotel { get; set; }

        [ForeignKey("RoomTypeId")]
        [JsonIgnore]
        public virtual Roomtypes? Roomtypes { get; set; }

        [ForeignKey("RoomStatusId")]
        [JsonIgnore]
        public virtual RoomStatus? RoomStatus { get; set; }
    }
}
