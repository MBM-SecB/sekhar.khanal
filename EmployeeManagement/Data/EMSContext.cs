using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data
{
    public class EMSContext : DbContext
    {
        //Creating Constructor
        public EMSContext()
        {
            
        }
        public EMSContext(DbContextOptions<EMSContext> options) : base(options)
        {

        }

        //Creating Table
        public DbSet<Employee> Employees { get; set; }
    }
}