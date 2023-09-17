using EducationInstitute.DTO;
using EducationInstitute.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EducationInstitute.Controllers
{
    public class AuthenticationController : Controller
    {
        [HttpPost("Login")]
        public async Task<ActionResult> Login(LoginDto login)
        {
            var db = new ApplicationDbContext();

            var user = await db.Users.Where(u => u.Username == login.UserName && u.Password == login.Password)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                return NotFound();
            }

            if (user.Role == "Admin")
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}