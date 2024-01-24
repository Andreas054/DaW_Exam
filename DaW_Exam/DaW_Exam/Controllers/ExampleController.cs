using DaW_Exam.Services.ExampleService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DaW_Exam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private IExampleService _exampleService;

        public ExampleController(IExampleService exampleService)
        {
            _exampleService = exampleService;
        }

        [HttpGet]
        public IActionResult GetById([FromHeader] Guid id) {
            return Ok(_exampleService.GetById(id));
        }
    }
}
