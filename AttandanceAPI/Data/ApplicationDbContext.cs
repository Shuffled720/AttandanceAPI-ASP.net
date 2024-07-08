using AttandanceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AttandanceAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base (options)
        {
            
        }

        public DbSet<Shed_Details> Shed_Details { get; set; }
        public DbSet<Shed_Incharge_Details> Shed_Incharge_Details { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
    }
}
