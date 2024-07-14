using DomeWarsBLL.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DomeWarsAPI.DTO;
using DomeWarsDomain.Entities;
using DomeWarsAPI.Tools;
using DomeWarsBLL.Services;
using Microsoft.Data.SqlClient;

namespace DomeWarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        private readonly TokenGenerator _tokenGenerator;

        public PlayerController(IPlayerService playerService, TokenGenerator tokenGenerator) {
            _playerService = playerService;
            _tokenGenerator = tokenGenerator;
        }

        /// <summary>
        /// Login to your account by entering your email and password
        /// </summary>
        /// <param name="loginInfo">Login form</param>
        /// <returns>A connection token</returns>
        [HttpPost("login/")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Login(LoginForm loginInfo)
        {
            if (!ModelState.IsValid) return BadRequest();

            try
            {
                Player connectedUser = _playerService.Login(loginInfo.Email, loginInfo.Password);
                string token = _tokenGenerator.GenerateToken(connectedUser);

                return Ok(new { connectedUser.Id, connectedUser.Username, connectedUser.Email, TokenRetourLog = token });
                //return Ok(token);
            }
            catch (SqlException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Create a new account by filling a form
        /// </summary>
        /// <param name="form">Create account form</param>
        /// <returns>Nothing</returns>
        [HttpPost("register/")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Register(RegisterForm form)
        {
            if (!ModelState.IsValid) return BadRequest();
            try
            {
                _playerService.Register(new Player { Username = form.Username, Email = form.Email }, form.Password);
                return Ok();
            }
            catch (SqlException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
