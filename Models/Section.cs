using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreEMS.Models
{
    public class Section
    {
        public string Id { get; set; }

        [Required]
        public Semester Semester { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Lecture> Lectures { get; set; }
    }
}