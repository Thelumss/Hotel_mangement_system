using System.ComponentModel.DataAnnotations;

namespace Hotel_mangement_system.Models
{
    public class AcsessLevels
    {
        [Key]
        public int Acsess_levels_Id { get; set; }
        public string Acsess_levels_Name { get; set; }
    }
}
