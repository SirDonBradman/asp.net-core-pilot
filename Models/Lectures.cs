using System.ComponentModel.DataAnnotations;

namespace CoreEMS.Models
{
    public class Lecture
    {
        public string Id { get; set; }

        public string RoomNumber { get; set; }

        [Required]
        public Teacher Teacher { get; set; }

        public string TeacherId { get; set; }

        [Required]
        public Subject Subject { get; set; }
        public string SubjectId { get; set; }

        [Required]
        public Section Section { get; set; }
        public string SectionId { get; set; }

        public int NumberOfClasses { get; set; }
    }
}