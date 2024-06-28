using DomeWarsAPI.DTO;
using DomeWarsBLL.Interfaces.Services;
using DomeWarsBLL.Services;
using DomeWarsDomain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DomeWarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController(IGameService gameService) : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(gameService.GetAll()
                .Select(g => new GameDTO(g)));
        }

        /// <summary>
        /// Creates a new player with a role set to User.
        /// </summary>
        /// <param name="form"> A form with the username, email address and password of the user.</param>
        /// <returns></returns>
        [HttpPost("Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Post([FromForm] AddGameForm form)
        {
            Game game = new Game
            {
                Name = form.Name,
                MaxRound = form.MaxRound,
                Password = form.Password,

            };
            gameService.NewGame(game);
            return Ok();
        }

        [HttpDelete("Delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Delete(int id)
        {
            gameService.Delete(id);
            return Ok();
        }
    }
}
