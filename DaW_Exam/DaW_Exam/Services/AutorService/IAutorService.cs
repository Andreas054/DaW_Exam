using DaW_Exam.Models.DTOs;
using DaW_Exam.Models.Many_to_Many;

namespace DaW_Exam.Services.AutorService
{
    public interface IAutorService
    {
        List<Autor> GetAll();

        bool Create(Autor autor);

        public bool CreateDTO(AutorDTO autorDTO);
    }
}
