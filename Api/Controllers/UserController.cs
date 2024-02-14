using System.Collections.Generic;
using learnApi.Models;
using learnApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace learnApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<List<User>> GetAllUsers()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpGet("{userId}")]
        public ActionResult<User> GetUserById(int userId)
        {
            var user = _userService.Get(userId);

            if (user == null)
            {
                return NotFound("User not found");
            }

            return Ok(user);
        }

        [HttpGet("{userId}/orders")]
        public ActionResult<List<Order>> GetOrdersForUser(int userId)
        {
            var user = _userService.Get(userId);

            if (user == null)
            {
                return NotFound("User not found");
            }

            var orders = user.Orders; // Asumiendo que User tiene una propiedad List<Order> llamada Orders
            return Ok(orders);
        }

        [HttpPost]
        public IActionResult CreateUser( User user)
        {
            _userService.Add(user);
            return CreatedAtAction(nameof(GetUserById), new { userId = user.Id }, user);
        }

        [HttpPut("{userId}")]
        public IActionResult UpdateUser(int userId, User updatedUser)
        {
            var existingUser = _userService.Get(userId);

            if (existingUser == null)
            {
                return NotFound("User not found");
            }

            // Actualizar propiedades según sea necesario
            existingUser.Name = updatedUser.Name;
            // Actualiza otras propiedades según tu modelo

            _userService.Update(existingUser);
            return NoContent();
        }

        [HttpDelete("{userId}")]
        public IActionResult DeleteUser(int userId)
        {
            var existingUser = _userService.Get(userId);

            if (existingUser == null)
            {
                return NotFound("User not found");
            }

            _userService.Delete(userId);
            return NoContent();
        }
    }
}
