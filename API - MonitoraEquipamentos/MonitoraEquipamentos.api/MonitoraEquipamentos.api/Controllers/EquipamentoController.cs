using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonitoraEquipamentos.Application.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoraEquipamentos.api.Controllers
{
    [Route("api/[controller]")]
    public class EquipamentoController : Controller
    {
        private readonly IEquipamentoService _equipService;

        public EquipamentoController(IEquipamentoService anuncioService)
        {
            _equipService = anuncioService;
        }

        [Authorize("Bearer")]        
        [HttpGet("BuscaEquipamentosStatus")]
        public object GetEquipamento()
        {
            try
            {
                return new
                {
                    Teste = "teste GetEquipamento",
                    Teste2 = "Teste2 GetEquipamento 2"
                };
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar buscar Equipamentos. Erro: {ex.Message}");
            }
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
                    $"Erro ao tentar buscar Equipamentos. Erro: {ex.Message}");
            }
        }
    }
}
