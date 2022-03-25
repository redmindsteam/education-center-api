namespace EducationCenter.Domain.Models.Entities
{
    public class Employee : Person
    {
        public string CardNumber { get; set; }

        public long Salary { get; set; }
    }
}
