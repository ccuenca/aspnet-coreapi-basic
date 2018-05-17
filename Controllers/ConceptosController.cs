using ConceptosService2.BusinessLogic.Conceptos;
using ConceptosService2.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ConceptosService2.Controllers
{
    [Route("api/conceptos")]
    public class ConceptosController : Controller
    {
        private readonly IConceptosBL _conceptosBL;

        public ConceptosController(IConceptosBL conceptosBL)
        {
            _conceptosBL = conceptosBL ?? throw new ArgumentNullException(nameof(conceptosBL));
        }


        [HttpGet("")]
        public async Task<IActionResult> GetAll([FromQuery] string type)
        {
            var conceptos = await _conceptosBL.GetAll(type);

            if (!conceptos.Any()) return NotFound();

            return Ok(conceptos);
        }        
    }
}