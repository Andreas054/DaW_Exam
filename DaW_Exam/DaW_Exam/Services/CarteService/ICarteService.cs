using DaW_Exam.Models.DTOs;
using DaW_Exam.Models.Many_to_Many;

namespace DaW_Exam.Services.CarteService
{
    public interface ICarteService
    {
        List<Carte> GetAll();

        bool Create(Carte carte);

        public bool CreateDTO(CarteDTO carteDTO);
    }
}
