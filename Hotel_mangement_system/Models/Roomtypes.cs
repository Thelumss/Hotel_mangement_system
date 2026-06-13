using System.ComponentModel.DataAnnotations;

namespace Hotel_mangement_system.Models
{
    public class Roomtypes
    {
        [Key]
        public int RoomtypesID { get; set; }
        public string TypeName { get; set; }
    }
}
