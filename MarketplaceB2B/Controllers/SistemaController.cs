using Microsoft.AspNetCore.Mvc;
using MarketplaceB2B.Services;

namespace MarketplaceB2B.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SistemaController : ControllerBase
    {
        private SistemaService sistema = new SistemaService();

        [HttpGet]
        public IActionResult Iniciar()
        {
            sistema.IniciarSistema();
            return Ok("Sistema iniciado com sucesso");
        }
    }
}