using System.ComponentModel.DataAnnotations;

namespace EntityAspMvcFirst.Models
{
    public class LoginUser
    {
        
        public int Id { get; set; }

        [Required]
        public string Username { get; set; } =null!;

        [Required]
        public string Password { get; set; } =null!;
    }
}
