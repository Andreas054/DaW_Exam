using AutoMapper;
using DaW_Exam.Models.DTOs;
using DaW_Exam.Models.Many_to_Many;
using DaW_Exam.Repositories.CarteRepository;

namespace DaW_Exam.Services.CarteService
{
    public class CarteService : ICarteService
    {
        public ICarteRepository _carteRepository;
        public IMapper _mapper;

        public CarteService(ICarteRepository carteRepository, IMapper mapper)
        {
            _carteRepository = carteRepository;
            _mapper = mapper;
        }

        public List<Carte> GetAll()
        {
            return _carteRepository.GetAll();
        }
        public bool Create(Carte carte)
        {
            return _carteRepository.Create(carte);
        }

        public bool CreateDTO(CarteDTO carteDTO)
        {
            return _carteRepository.CreateDTO(carteDTO);
        }
    }
}
