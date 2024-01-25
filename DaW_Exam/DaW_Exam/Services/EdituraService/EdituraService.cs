using AutoMapper;
using DaW_Exam.Models;
using DaW_Exam.Models.DTOs;
using DaW_Exam.Repositories.EdituraRepository;

namespace DaW_Exam.Services.EdituraService
{
    public class EdituraService : IEdituraService
    {
        public IEdituraRepository _edituraRepository;
        public IMapper _mapper;

        public EdituraService(IEdituraRepository edituraRepository, IMapper mapper)
        {
            _edituraRepository = edituraRepository;
            _mapper = mapper;
        }

        public List<Editura> GetAll()
        {
            return _edituraRepository.GetAll();
        }
        public bool Create(Editura editura)
        {
            return _edituraRepository.Create(editura);
        }

        public bool CreateDTO(EdituraDTO edituraDTO)
        {
            return _edituraRepository.CreateDTO(edituraDTO);
        }
    }
}
