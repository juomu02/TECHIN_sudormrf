
using Microsoft.AspNetCore.Mvc;
using MySavings.Services;

namespace MySavings.API.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var user = await userService.GetAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpPost("{userName}/{email}/{password}")]
        public async Task<IActionResult> CreateAsync(string userName, string email, string password)
        {
            var userId = await userService.AddAsync(userName, email, password);
            return Ok(userId);
        }
    }
}