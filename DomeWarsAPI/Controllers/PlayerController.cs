using DomeWarsBLL.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DomeWarsAPI.DTO;
using DomeWarsDomain.Entities;

namespace DomeWarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController(IPlayerService playerService) : ControllerBase
    {
        /// <summary>
        /// Obtains a list of every existing user
        /// </summary>
        /// <returns>A list of all users in the database</returns>
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(playerService.GetAll()
                .Select(p => new PlayerDTO(p)));
        }

        /// <summary>
        /// Creates a new player with a role set to User.
        /// </summary>
        /// <param name="form"> A form with the username, email address and password of the user.</param>
        /// <returns></returns>
        [HttpPost("Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Post([FromForm] AddPlayerForm form)
        {
            Player player = new Player
            {
                Username = form.Username,
                Email = form.Email,
                Password =form.Password,
                
            };
            playerService.Add(player);
            return Ok();
        }

        [HttpDelete("Delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Delete(int id)
        {
            playerService.Delete(id);
            return Ok();
        }

    }
}
