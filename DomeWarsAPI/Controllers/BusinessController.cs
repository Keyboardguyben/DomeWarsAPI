using Microsoft.AspNetCore.Mvc;
using DomeWarsBLL.Services;
using DomeWarsBLL.Interfaces.Services;
using DomeWarsAPI.DTO;

namespace DomeWarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController(IBusinessService businessService) : Controller
    {
        [HttpGet("GetByTerritory")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByGame(int TerrId)
        {
            return Ok(businessService.GetByTerritory(TerrId).Select(b => new BusinessDTO(b)));
        }
    }
}
