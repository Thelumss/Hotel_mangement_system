using System.ComponentModel.DataAnnotations;

namespace Hotel_mangement_system.Models
{
    public class Amenities
    {
        [Key]
        public int AmenitiesId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string opening_hours { get; set; }
    }
}
