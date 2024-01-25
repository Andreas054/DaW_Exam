using DaW_Exam.Models.DTOs;
using DaW_Exam.Models.Many_to_Many;
using DaW_Exam.Repositories.GenericRepository;

namespace DaW_Exam.Repositories.CarteRepository
{
    public interface ICarteRepository : IGenericRepository<Carte>
    {
        public bool CreateDTO(CarteDTO carteDTO);
    }
}
