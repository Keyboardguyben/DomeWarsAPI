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

        [HttpGet("GetByGame")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByGame(int GameId) 
        {
            return Ok(territoryService.GetByGame(GameId).Select(t => new TerritoryDTO(t)));
        }

        

    }
}
