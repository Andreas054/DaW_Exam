using DaW_Exam.Models.DTOs;
using DaW_Exam.Models.Many_to_Many;
using DaW_Exam.Services.AutorService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DaW_Exam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private IAutorService _autorService;

        public AutorController(IAutorService autorService)
        {
            _autorService = autorService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAllAutori()
        {
            return Ok(_autorService.GetAll());
        }

        [HttpPost()]
        public IActionResult CreateAutor([FromBody] Autor autor)
        {
            return Ok(_autorService.Create(autor));
        }

        [HttpPost("autorDTO")]
        public IActionResult CreateAutorDTO([FromBody] AutorDTO autorDTO)
        {
            return Ok(_autorService.CreateDTO(autorDTO));
        }
    }
}
