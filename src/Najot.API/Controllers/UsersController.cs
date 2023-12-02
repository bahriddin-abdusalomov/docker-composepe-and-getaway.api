using Microsoft.AspNetCore.Mvc;
using Najot.Application.Interface.Users;
using Najot.Domain.Entity.Users;

namespace Najot.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userSerivce;

        public UsersController(IUserService userSerivce)
        {
            _userSerivce = userSerivce;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(User user)
        {
            bool result = await _userSerivce.CreateAsync(user);
            return Ok(result);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            var users = await _userSerivce.GetAllAsync();
            return Ok(users);
        }
    }
}
