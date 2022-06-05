using AgendaConsultaAPI.Model;
using AgendaConsultaAPI.Model.Entities.Consultas;
using AgendaConsultaAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AgendaConsultaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {

        private readonly IConsultaRepository repos;
        public ConsultaController(IConsultaRepository _repos)
        {
            repos = _repos;

        }
        
        [HttpGet]
        public ActionResult GetConsultas()
        {
            return Ok(repos.getAll());
        }



        [HttpGet("{Id}")]
        public IActionResult Get([FromRoute]ConsultaId consulta)
        {
            var consulta_db = repos.Read(consulta.Id);
            return Ok(consulta_db);
        }

        [HttpPost]
        public IActionResult Post(PostConsultas consulta)
        {
            if (repos.Create(consulta))
                return Ok();

            return BadRequest();
        }

        [HttpPut]
        public IActionResult Put(PutConsultas consulta)
        {
            if (repos.Update(consulta))
                return Ok();

            return BadRequest();
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete([FromRoute] ConsultaId consulta)
        {
            if (repos.Delete(consulta.Id))
            {
                return Ok();
            }
                
            return BadRequest();
        }



    }
}
