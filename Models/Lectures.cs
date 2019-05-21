using System.ComponentModel.DataAnnotations;

namespace CoreEMS.Models
{
    public class Lecture
    {
        public string Id { get; set; }

        public string RoomNumber { get; set; }

        [Required]
        public Teacher Teacher { get; set; }

        [Required]
        public Subject Subject { get; set; }

        [Required]
        public Section Section { get; set; }

        public int NumberOfClasses { get; set; }
    }
}