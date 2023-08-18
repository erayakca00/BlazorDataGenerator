using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BlazorDataGenerator.Data
{

    public class Employee
    {
        [Key]
        public int? Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public int? Salary { get; set; }

        public DateOnly Recruitment { get; set; }

        public string? Country { get; set; }

        public string? City { get; set; }   
        
        public string? Street { get; set; }  

        public int? Age { get; set; }

        public Positions? Position { get; set; }   
        
        public string? Email { get; set; }

    }
}
