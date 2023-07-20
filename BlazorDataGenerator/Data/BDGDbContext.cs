using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Security.Cryptography.X509Certificates;
using BlazorDataGenerator.Data;

namespace BlazorDataGenerator.Data
{
    public class BDGDbContext : DbContext
    {
        public BDGDbContext()
        {
        }

        public BDGDbContext(DbContextOptions<BDGDbContext> options) : base(options)
        {

        }


        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var connectionString = configuration.GetConnectionString("DbConnection");
                optionsBuilder.UseNpgsql(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
            entity.ToTable("Employee", "public");

            entity.HasKey(i => i.Id);

            entity.Property(i => i.Id).HasColumnName("Id").HasColumnType("integer").IsRequired();
            entity.Property(i => i.FirstName).HasColumnName("First_Name").HasColumnType("character varying").HasMaxLength(100);
            entity.Property(i => i.LastName).HasColumnName("Last_Name").HasColumnType("character varying").HasMaxLength(100);
            entity.Property(i => i.Salary).HasColumnName("Salary").HasColumnType("integer");
            entity.Property(i => i.Recruitment).HasColumnName("Recruitment").HasColumnType("integer");
            entity.Property(i => i.Country).HasColumnName("Country").HasColumnType("character varying");
            entity.Property(i => i.Street).HasColumnName("Street").HasColumnType("character varying");
            entity.Property(i => i.City).HasColumnName("City").HasColumnType("character varying");
            entity.Property(i => i.Age).HasColumnName("Age").HasColumnType("integer");
            entity.Property(i => i.Position).HasColumnName("Position").HasColumnType("character varying");
            entity.Property(i => i.Email).HasColumnName("Email").HasColumnType("character varying");
            });




        } 
    }
}
