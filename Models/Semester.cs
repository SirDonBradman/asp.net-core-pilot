using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreEMS.Models
{
    public class Semester
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Department Department { get; set; }
        public List<Section> Sections { get; set; }
    }
}