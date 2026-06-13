using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Hotel_mangement_system.Data
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Hotel_System;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

            return new DataContext(optionsBuilder.Options);
        }
    }
}
