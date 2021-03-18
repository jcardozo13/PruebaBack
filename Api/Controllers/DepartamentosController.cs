using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Servicios.Interface;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class DepartamentosController : Controller
    {

        private readonly IServicioDepartamentos servicio;
        public DepartamentosController(IServicioDepartamentos _servicio)
        {
            servicio = _servicio;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var data = servicio.DepartamentosTodos();
            return Ok(data);
        }

    }
}
