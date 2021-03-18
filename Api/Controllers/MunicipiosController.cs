using Microsoft.AspNetCore.Mvc;
using Servicios.Interface;
using Datos.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
   
    public class MunicipiosController : Controller
    {
        private readonly IServiciosMunicipios servicio;
        public MunicipiosController(IServiciosMunicipios _servicio)
        {
            servicio = _servicio;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var data = servicio.MunicipiosTodos();
            return Ok(data);
        }

        [HttpPost]
        public ActionResult SaveProvince(MunicipiosDTO municipio)
        {
            var data = servicio.GuardarMunicipio(municipio);
            return Ok(data);
        }

        [HttpDelete]
        public ActionResult DeleteProvince(int idMunicipio)
        {
            var data = servicio.EliminaMunicipio(idMunicipio);
            return Ok(data);
        }
    }
}
