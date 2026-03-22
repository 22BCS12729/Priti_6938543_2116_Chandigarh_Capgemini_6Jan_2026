using System.ComponentModel.DataAnnotations;

namespace JwtMvcDemo.Models
{
    public class User
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}