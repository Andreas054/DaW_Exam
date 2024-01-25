using DaW_Exam.Models;
using DaW_Exam.Models.DTOs;
using DaW_Exam.Services.EdituraService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DaW_Exam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EdituraController : ControllerBase
    {
        private IEdituraService _edituraService;

        public EdituraController(IEdituraService edituraService)
        {
            _edituraService = edituraService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAllEdituri()
        {
            return Ok(_edituraService.GetAll());
        }

        [HttpPost()]
        public IActionResult CreateEditura([FromBody] Editura editura)
        {
            return Ok(_edituraService.Create(editura));
        }

        [HttpPost("edituraDTO")]
        public IActionResult CreateEdituraDTO([FromBody] EdituraDTO edituraDTO)
        {
            return Ok(_edituraService.CreateDTO(edituraDTO));
        }
    }
}
