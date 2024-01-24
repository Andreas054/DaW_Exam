using AutoMapper;
using DaW_Exam.Models;
using DaW_Exam.Repositories.ExampleRepository;

namespace DaW_Exam.Services.ExampleService
{
    public class ExampleService : IExampleService
    {
        public IExampleRepository _exampleRepository;
        public IMapper _mapper;

        public ExampleService(IExampleRepository exampleRepository, IMapper mapper)
        {
            _exampleRepository = exampleRepository;
            _mapper = mapper;
        }

        public Example GetById(Guid id)
        {
            return _exampleRepository.FindById(id);
        }
    }
}
