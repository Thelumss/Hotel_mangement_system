using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Hotel_mangement_system.Models
{
    public class HotelAmenitites
    {
        [Key]
        public int HotelAmenititesId { get; set; }

        public int AmenititesId { get; set; }
        public int HotelId { get; set; }

        [ForeignKey("AmenititesId")]
        [JsonIgnore]
        public virtual Amenities? Amenitites { get; set; }

        [ForeignKey("HotelId")]
        [JsonIgnore]
        public virtual Hotel? Hotel { get; set; }
    }
}
