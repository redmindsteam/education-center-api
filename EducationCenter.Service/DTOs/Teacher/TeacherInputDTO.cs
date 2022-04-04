using System;
using System.ComponentModel.DataAnnotations;

namespace EducationCenter.Service.DTOs.Teacher
{
    public class TeacherInputDTO
    {
        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        public string Middlename { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public string CardNumber { get; set; }

        public long Salary { get; set; }
    }
}
