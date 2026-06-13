using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Hotel_mangement_system.Models
{
    public class RoomAmenities
    {
        [Key]
        public int RoomAmenitiesId { get; set; }

        public int RoomId { get; set; }
        public int AmenitiesId { get; set; }

        [ForeignKey("RoomId")]
        [JsonIgnore]
        public virtual Room? Room { get; set; }

        [ForeignKey("AmenitiesId")]
        [JsonIgnore]
        public virtual Amenities? Amenities { get; set; }
    }
}
