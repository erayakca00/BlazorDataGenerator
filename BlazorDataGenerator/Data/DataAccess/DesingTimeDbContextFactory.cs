using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BlazorDataGenerator.Data.DataAccess
{
    public class DesingTimeDbContextFactory : IDesignTimeDbContextFactory<BDGDbContext>
    {
        public BDGDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<BDGDbContext> dbContextOptionsBuilder = new();
           // dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}