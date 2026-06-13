using System.ComponentModel.DataAnnotations;

namespace Hotel_mangement_system.Models
{
    public class Guest
    {
        [Key]
        public int Guest_Id { get; set; }
        public string Guest_Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address{ get; set; }


    }
}
