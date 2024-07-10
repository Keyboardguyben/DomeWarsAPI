using DomeWarsAPI.DTO;
using DomeWarsBLL.Interfaces.Services;
using DomeWarsBLL.Services;
using DomeWarsDomain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DomeWarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerritoryController(ITerritoryService territoryService) : Controller
    {
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(territoryService.GetAll()
                .Select(t => new TerritoryDTO(t)));
        }

        [HttpGet("GetByGame/{gameId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByGame([FromRoute] int gameId)
        {
            return Ok(territoryService.GetByGame(gameId).Select(t => new TerritoryDTO(t)));
        }

        [HttpGet("GetFullMap/{gameId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetFullGame([FromRoute] int gameId) 
        {
            return Ok(territoryService.GetFullMap(gameId));
        }

        [HttpGet("GetById/{territoryId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetById([FromRoute]int id) 
        {
            TerritoryDTO t = new TerritoryDTO(territoryService.GetById(id));
            return Ok(t);
        }

    }
}
