using System;
using System.ComponentModel.DataAnnotations;

namespace CoreEMS.Models
{
    public class Student : AppUser
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Guardian Guardian { get; set; }
        
        public string GuardianId { get; set; }

        public Section Section { get; set; }
        public string SectionId { get; set; }

        public DateTime DateOfBirth { get; set; }
        
        public Gender Gender { get; set; }

        public string BloodGroup { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        
        public string Photo { get; set; }

        public string RegistrationNumber { get; set; }

        public string RollNumber { get; set; }

    }
}