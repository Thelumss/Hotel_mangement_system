using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Hotel_mangement_system.Models
{
    public class Hotel
    {
        [Key] 
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string Location { get; set; }
        public float Rating { get; set; }
        public string Contact_info { get; set; }
        public int OrganisationId { get; set; }

        [ForeignKey("OrganisationId")]
        [JsonIgnore]
        public virtual Organisation? Organisation { get; set; }
    }
}
