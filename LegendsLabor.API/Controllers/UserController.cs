using LegendsLabor.Core.Domain.Entities;
using LegendsLabor.Core.Models;
using LegendsLabor.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LegendsLabor.API.Controllers
{
    [Route("api/[controller]", Name = "User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger<User> _logger;

        public UserController(IUserService userService, ILogger<User> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult> CreateUser(User newUser)
        {
            var result = await _userService.CreateAsync(newUser);
            if (!result.IsSuccess)
                return BadRequest(result.Error);
            return Created($"/api/users/{result.Value?.Id}", result.Value);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(User userToUpdate)
        {
            var result = await _userService.UpdateAsync(userToUpdate);
            if (!result.IsSuccess)
                return NotFound(result.Error);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var result = await _userService.DeleteAsync(id);
            if (!result.IsSuccess)
                return NotFound(result.Error);
            return NoContent();
        }
    }
}
