using DomeWarsAPI.DTO;
using DomeWarsBLL.Interfaces.Services;
using DomeWarsBLL.Services;
using DomeWarsDAL.Migrations;
using DomeWarsDomain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DomeWarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GangController(IGangService gangService) : Controller
    {
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            Console.WriteLine("Coucou1");
            return Ok(gangService.GetAll()
                .Select(g => new GangDTO(g)));
        }

        [HttpPost("Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Post([FromForm] AddGangForm form)
        {
            Gang gang = new Gang
            {
                Name = form.Name,
                Color = form.Color

            };
            gangService.NewGang(gang);
            return Ok();
        }
    }
}
