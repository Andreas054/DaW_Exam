using DaW_Exam.Data;
using DaW_Exam.Models.DTOs;
using DaW_Exam.Models.Many_to_Many;
using DaW_Exam.Repositories.GenericRepository;

namespace DaW_Exam.Repositories.CarteRepository
{
    public class CarteRepository : GenericRepository<Carte>, ICarteRepository
    {
        public CarteRepository(AppDatabaseContext appDatabaseContext) : base(appDatabaseContext) { }

        public bool CreateDTO(CarteDTO carteDTO)
        {
            var newCarte = new Carte
            {
                Id = Guid.NewGuid(),
                ISIN = carteDTO.ISIN,
            };

            Create(newCarte);
            Save();
            return true;
        }
    }
}
