using LegendsLabor.Core.Domain.Entities;
using LegendsLabor.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LegendsLabor.API.Controllers
{
    [Route("api/[controller]")]
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
        public async Task<ActionResult<User>> CreateUser(User newUser) // Using a DTO here is recommended
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdUser = await _userService.CreateAsync(newUser);
            return Created($"/api/users/{createdUser.Id}", createdUser);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(User userToUpdate) // Use a DTO here
        {
            try
            {
                await _userService.UpdateAsync(userToUpdate);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            await _userService.DeleteAsync(id);
            return NoContent();
        }

    }
}
