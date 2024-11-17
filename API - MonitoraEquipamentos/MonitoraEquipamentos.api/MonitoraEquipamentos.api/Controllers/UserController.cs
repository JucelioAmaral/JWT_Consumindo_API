using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonitoraEquipamentos.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoraEquipamentos.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("BuscaTodosUsuarios")]
        public async Task<IActionResult> BuscaTodosUsuarios()
        {
            try
            {
                var usuarios = await _userService.GetAllUsers();
                if (usuarios == null) return NoContent();

                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar buscar usuários. Erro: {ex.Message}");
            }
        }

        [HttpGet("BuscaUsuarioPorUsuarioId/{userid}")]
        public async Task<IActionResult> BuscaUsuarioPorUsuarioId(string userid)
        {
            try
            {
                var usuario = await _userService.GetUserByUserId(userid);
                if (usuario == null) return NoContent();

                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar buscar usuário. Erro: {ex.Message}");
            }
        }
    }
}
