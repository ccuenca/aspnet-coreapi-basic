using Microsoft.AspNetCore.Mvc;

namespace ConceptosService2.Controllers
{
    [Route("api/test")]
    public class TestController : Controller
    {
        //Expresion body members
        public IActionResult Get() => Content("Hello ASP.NET Core :)");
    }
}