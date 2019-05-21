using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreEMS.Models
{
    public class Subject
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Semester Semester { get; set; }
        public string SemesterId { get; set; }

        [Required]
        public SubjectType SubjectType { get; set; }

        [Required]
        public string SubjectCode { get; set; }

        public List<Book> ReferenceBooks { get; set; }
    }
}