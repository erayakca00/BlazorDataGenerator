using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace BlazorDataGenerator.Data
{
    public class BDGDbContext : DbContext
    {
        public BDGDbContext(DbContextOptions<BDGDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        
            
            

    }
}
