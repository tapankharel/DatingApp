using System.ComponentModel.DataAnnotations;

namespace DatingApp.Api.Dtos
{
    public class UserForLoginDtos
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}