using DaW_Exam.Models;
using DaW_Exam.Models.DTOs;
using DaW_Exam.Repositories.GenericRepository;

namespace DaW_Exam.Repositories.EdituraRepository
{
    public interface IEdituraRepository : IGenericRepository<Editura>
    {
        public bool CreateDTO(EdituraDTO edituraDTO);
    }
}
