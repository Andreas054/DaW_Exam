using AutoMapper;
using DaW_Exam.Models.DTOs;
using DaW_Exam.Models.Many_to_Many;

namespace DaW_Exam.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Autor, AutorDTO>();
            CreateMap<AutorDTO, Autor>();
        }
    }
}
