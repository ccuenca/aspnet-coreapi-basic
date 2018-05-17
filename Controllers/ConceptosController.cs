using System.Threading.Tasks;
using ConceptosService2.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ConceptosService2.Controllers
{
    [Route("api/conceptos")]
    public class ConceptosController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> createConcepto([FromBody] Concepto concepto){
            
            
            return Ok();
        }


       
    }
}