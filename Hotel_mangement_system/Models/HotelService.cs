using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Hotel_mangement_system.Models
{
    public class HotelService
    {
        [Key] 
        public int HotelServiceId { get; set; }
        public int ServiceId { get; set; }

        [ForeignKey("ServiceId")]
        [JsonIgnore]
        public virtual Service? Service { get; set; }
    }
}
