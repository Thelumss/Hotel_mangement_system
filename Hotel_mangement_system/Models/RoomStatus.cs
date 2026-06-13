using System.ComponentModel.DataAnnotations;

namespace Hotel_mangement_system.Models
{
    public class RoomStatus
    {
        [Key]
        public int RoomStatusID { get; set; }
        public string RoomStatusName { get; set; }
    }
}
