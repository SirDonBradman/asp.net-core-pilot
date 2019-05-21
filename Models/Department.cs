using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreEMS.Models
{
    public class Department
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Semester> Semesters { get; set; }
    }
}