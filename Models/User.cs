using System.ComponentModel.DataAnnotations;

namespace CoreEMS.Models
{
    public class AppUser
    {
        public string Username { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}