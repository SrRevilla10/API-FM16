using CORE_FM16.Entidades;
using CORE_FM16.Repositorio.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace API_FM16.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormularioRegistro : ControllerBase
    {
        private readonly IPersonalFormularioRegistro _iPersonalForularioRegistro;

        public FormularioRegistro(IPersonalFormularioRegistro personaFormularioRegistro)
        { 
          _iPersonalForularioRegistro = personaFormularioRegistro;
        }

      

        [HttpGet]
        public async Task<List<CRMPersonalFormularioRegistro>> ObtienePersonalFormularioRegistro([FromQuery] string accion)
        {
            List<CRMPersonalFormularioRegistro> LSTpfr = await _iPersonalForularioRegistro.GetPersonalFormularioRegistro(accion);

            var entero = 0;

            return LSTpfr;
        }

    }
}
