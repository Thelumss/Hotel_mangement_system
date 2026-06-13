using System.ComponentModel.DataAnnotations;

namespace Hotel_mangement_system.Models
{
    public class Organisation
    {
        [Key] 
        public int OrganisationId { get; set; }
        public string OrganisationName { get; set; }
    }
}
