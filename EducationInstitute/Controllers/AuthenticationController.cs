using EducationInstitute.DTO;
using EducationInstitute.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EducationInstitute.Controllers
{
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        //private readonly IUserService _userService;
        //public AuthenticationController(IUserService userService)
        //{
        //    _userService = userService;
        //}

        [HttpPost("Login")]
        public async Task<ActionResult> Login([FromBody] LoginDto login)
        {
            //var user = await _userService.Login(login);

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