using DaW_Exam.Models.DTOs;
using DaW_Exam.Models.Many_to_Many;
using DaW_Exam.Services.CarteService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DaW_Exam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarteController : ControllerBase
    {
        private ICarteService _carteService;

        public CarteController(ICarteService carteService)
        {
            _carteService = carteService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAllCarti()
        {
            return Ok(_carteService.GetAll());
        }

        [HttpPost()]
        public IActionResult CreateCarte([FromBody] Carte carte)
        {
            return Ok(_carteService.Create(carte));
        }

        [HttpPost("carteDTO")]
        public IActionResult CreateCarteDTO([FromBody] CarteDTO carteDTO)
        {
            return Ok(_carteService.CreateDTO(carteDTO));
        }
    }
}
