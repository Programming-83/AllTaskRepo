using Microsoft.EntityFrameworkCore;

namespace FristCrud.Models
    
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options):base(options) 
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<HrDeportment> HRteams { get; set; }
    }
}
