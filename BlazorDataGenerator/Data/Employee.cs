using System.ComponentModel.DataAnnotations;

namespace BlazorDataGenerator.Data
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Salary { get; set; }

        public int Recruitment { get; set; }

        public string Address { get; set; }

        public int Age { get; set; }

        public string Position { get; set; }    

    }
}
