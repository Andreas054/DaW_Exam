using AutoMapper;
using DaW_Exam.Models.DTOs;
using DaW_Exam.Models.Many_to_Many;
using DaW_Exam.Repositories.AutorRepository;

namespace DaW_Exam.Services.AutorService
{
    public class AutorService : IAutorService
    {
        public IAutorRepository _autorRepository;
        public IMapper _mapper;

        public AutorService(IAutorRepository autorRepository, IMapper mapper)
        {
            _autorRepository = autorRepository;
            _mapper = mapper;
        }

        public List<Autor> GetAll()
        {
            return _autorRepository.GetAll();
        }
        public bool Create(Autor autor)
        {
            return _autorRepository.Create(autor);
        }

        public bool CreateDTO(AutorDTO autorDTO)
        {
            return _autorRepository.CreateDTO(autorDTO);
        }
    }
}
