using DomeWarsAPI.DTO;
using DomeWarsBLL.Interfaces.Services;
using DomeWarsBLL.Services;
using DomeWarsDomain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace DomeWarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController(IGameService gameService) : Controller
    {
        /// <summary>
        /// Get all games
        /// </summary>
        /// <returns>List of all games in DB</returns>
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(gameService.GetAll()
                .Select(g => new GameDTO(g)));
        }

        /// <summary>
        /// Get all games still at round 0
        /// </summary>
        /// <returns>A list of all games still at round 0</returns>
        [HttpGet("GetNonStarted")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetNonStarted() 
        {
            return Ok(gameService.GetNonStarted()
                .Select(g => new GameDTO(g)));
        }

        /// <summary>
        /// Get the count of the players connected to a game
        /// </summary>
        /// <param name="id"> Game id</param>
        /// <returns>The count of players</returns>
        [HttpGet("PlayerCount/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetPlayerCount([FromRoute]int id) 
        {
            return Ok(gameService.GetPlayerCount(id));
        }

        /// <summary>
        /// Creates a new player with a role set to User.
        /// </summary>
        /// <param name="form"> A form with the username, email address and password of the user.</param>
        /// <returns></returns>
        [HttpPost("Create")]
        [Authorize("isConnectedPolicy")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Post([FromBody] AddGameForm form)
        {
            int id;
            Game game = new Game
            {
                Name = form.Name,
                MaxRound = form.MaxRound,
                Password = form.Password,
                PlayerNumber = form.PlayerNumber,
                PlayersInGame = 0,
            };
            id = gameService.NewGame(game);
            return Ok(id);
        }

        /// <summary>
        /// Delete a Game from server
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An Ok signal</returns>
        [HttpDelete("Delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Delete(int id)
        {
            gameService.Delete(id);
            return Ok();
        }
    }
}
