using System;
using System.ComponentModel.DataAnnotations;

namespace CoreEMS.Models
{
    public class Guardian : AppUser
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Student Student { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Phone { get; set; }

        public string Photo { get; set; }

    }
}