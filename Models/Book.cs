using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreEMS.Models
{
    public class Book
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }
    }
}