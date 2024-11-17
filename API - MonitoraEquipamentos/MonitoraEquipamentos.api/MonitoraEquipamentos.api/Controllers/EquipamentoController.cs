using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonitoraEquipamentos.Application.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoraEquipamentos.api.Controllers
{
    public class EquipamentoController : ControllerBase
    {
        private readonly IEquipamentoService _equipService;

        public EquipamentoController(IEquipamentoService anuncioService)
        {
            _equipService = anuncioService;
        }


        [HttpGet("BuscaEquipamentos")]
        public async Task<IActionResult> BuscaEquipamentos()
        {
            try
            {
                var equip = await _equipService.GetAllEquipamentos();
                if (equip == null) return NoContent();

                return Ok(equip);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar buscar anuncio. Erro: {ex.Message}");
            }
        }
    }
}
