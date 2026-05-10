using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace MarketplaceB2B.Controllers
{
    [ApiController]
    [Route("api/upload")]
    public class UploadController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> EnviarArquivo(IFormFile arquivo)
        {
            if (arquivo == null || arquivo.Length == 0)
            {
                return BadRequest("Arquivo não enviado");
            }

            var caminho = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", arquivo.FileName);

            using (var stream = new FileStream(caminho, FileMode.Create))
            {
                await arquivo.CopyToAsync(stream);
            }

            return Ok("Arquivo enviado com sucesso");
        }
    }
}