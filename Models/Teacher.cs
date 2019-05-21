using System;
using System.ComponentModel.DataAnnotations;

namespace CoreEMS.Models
{
    public class Teacher: AppUser
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Designation { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public Gender Gender { get; set; }
 
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }
        public string Photo { get; set; }

    }
}