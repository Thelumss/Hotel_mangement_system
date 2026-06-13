using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Hotel_mangement_system.Models
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Acsess_levels_Id { get; set; }
        public int OrganisationId { get; set; }

        [ForeignKey("Acsess_levels_Id")]
        [JsonIgnore]
        public virtual AcsessLevels? AcsessLevels { get; set; }

        [ForeignKey("OrganisationId")]
        [JsonIgnore]
        public virtual Organisation? Organisation { get; set; }
    }
}
