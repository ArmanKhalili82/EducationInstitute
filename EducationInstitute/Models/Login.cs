using System.ComponentModel.DataAnnotations;

namespace EducationInstitute.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Username is requried!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is requried!")]
        public string Password { get; set; }
    }
}
