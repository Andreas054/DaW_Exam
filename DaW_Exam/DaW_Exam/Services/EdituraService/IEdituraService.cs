using DaW_Exam.Models;
using DaW_Exam.Models.DTOs;

namespace DaW_Exam.Services.EdituraService
{
    public interface IEdituraService
    {
        List<Editura> GetAll();

        bool Create(Editura editura);

        public bool CreateDTO(EdituraDTO edituraDTO);
    }
}
