using Bogus;
using BlazorDataGenerator.Data;
using System.Security.Cryptography.X509Certificates;

namespace BlazorDataGenerator.Data
{
    public class DataBuilder
    {
        readonly Faker<Employee> EmployeeFake;

        public DataBuilder() 
        {
            EmployeeFake = new Faker<Employee>()
                .RuleFor(i => i.Email, i => i.Person.Email)
                .RuleFor(i => i.Country, f => f.Address.Country())
                .RuleFor(i => i.City, f => f.Address.City())
                .RuleFor(i => i.Street, f => f.Address.StreetAddress())
                .RuleFor(i => i.Age, i => i.Random.Int(18, 65))
                .RuleFor(i => i.FirstName, i => i.Person.FirstName)
                .RuleFor(i => i.LastName, i => i.Person.LastName)
                .RuleFor(i => i.Position, f => f.PickRandom<Positions>())
                .RuleFor(i => i.Salary, i => i.Random.Int(3000, 50000))
                .RuleFor(i => i.Id, i => i.Random.Int(1000, 9999))
                .RuleFor(i => i.Recruitment, i => i.Date.PastDateOnly(23));
        }

        public IEnumerable<Employee> GenerateEmployees()
        {
            return EmployeeFake.GenerateForever();
        }
    }
}
