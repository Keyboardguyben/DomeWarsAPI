﻿using DomeWarsAPI.DTO;
using DomeWarsBLL.Interfaces.Services;
using DomeWarsBLL.Services;
using DomeWarsDAL.Migrations;
using DomeWarsDomain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DomeWarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GangController(IGangService gangService) : Controller
    {
        [HttpGet("GetById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetById(int id)
        {
            GangDTO g = new GangDTO(gangService.GetById(id));
            return Ok(g);
        }

        [HttpGet("GetGameGangs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetGameGangs(int gameid) 
        {
            return Ok(gangService.GetGameGangs(gameid));
        }

        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(gangService.GetAll()
                .Select(g => new GangDTO(g)));
        }

        [HttpPost("Create")]
        [Authorize("isConnectedPolicy")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Post([FromBody] AddGangForm form)
        {
            Gang gang = new Gang
            {
                Name = form.Name,
                Color = form.Color,
                GameId = form.GameId,
                PlayerId = form.PlayerId,

            };
            gangService.NewGang(gang);
            return Ok(1);
        }
    }
}
