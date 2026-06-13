using Hotel_mangement_system.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_mangement_system.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<AcsessLevels> Acsess_levels { get; set; }
    }
}
