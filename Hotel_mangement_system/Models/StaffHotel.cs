using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Hotel_mangement_system.Models
{
    public class StaffHotel
    {
        [Key]
        public int StaffHotelId { get; set; }
        public int StaffId { get; set; }
        public int HotelId { get; set; }

        [ForeignKey("StaffId")]
        [JsonIgnore]
        public virtual Staff? Staff { get; set; }

        [ForeignKey("HotelId")]
        [JsonIgnore]
        public virtual Hotel? Hotel { get; set; }
    }
}
