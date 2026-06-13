using System.ComponentModel.DataAnnotations;
namespace Hotel_mangement_system.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

    }
}
