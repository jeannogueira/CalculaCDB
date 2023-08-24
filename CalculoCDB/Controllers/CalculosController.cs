using CalculoCDB.Domain;
using CalculoCDB.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalculoCDB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculosController : ControllerBase
    {

        private readonly ICalculoService calculoService;

        public CalculosController(ICalculoService calculoService)
        {
            this.calculoService = calculoService;
        }

        [HttpPost]
        public Resultado Post(Calculo calculo)
        {
            var resultado = calculoService.CalculaCDB(calculo);

            return resultado;
        }
    }
}
