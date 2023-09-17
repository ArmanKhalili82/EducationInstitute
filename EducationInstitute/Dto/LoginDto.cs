using System.ComponentModel.DataAnnotations;

namespace EducationInstitute.DTO
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Username is requried!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is requried!")]
        public string Password { get; set; }
    }
}
