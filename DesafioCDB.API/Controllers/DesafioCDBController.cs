using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DesafioCDB.Servicos;

namespace DesafioCDB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesafioCDBController : ControllerBase
    {
        private readonly IDesafioCDBServico desafioCDBServico;

        public DesafioCDBController(IDesafioCDBServico _desafioCDBServico)
        {
            this.desafioCDBServico = _desafioCDBServico;
        }

        [HttpGet("RetornarInicialFinal/{valor}/{qtdMeses}")]
        public IActionResult ReturnarCalculo(double valor, int qtdMeses)
        {

            try
            {
                var resultadoCDB = desafioCDBServico.RetornarEstimativaCalculoCDB(valor, qtdMeses);

                return Ok(resultadoCDB);
            }
            catch (Exception ex)
            {
                throw ex;
            }
  
        }

    }
}
