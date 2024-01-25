using DaW_Exam.Models.DTOs;
using DaW_Exam.Models.Many_to_Many;
using DaW_Exam.Repositories.GenericRepository;

namespace DaW_Exam.Repositories.AutorRepository
{
    public interface IAutorRepository : IGenericRepository<Autor>
    {
        public bool CreateDTO(AutorDTO autorDTO);
    }
}
