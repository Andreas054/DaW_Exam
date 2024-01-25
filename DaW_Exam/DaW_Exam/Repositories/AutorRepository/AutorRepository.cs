using DaW_Exam.Data;
using DaW_Exam.Models.DTOs;
using DaW_Exam.Models.Many_to_Many;
using DaW_Exam.Repositories.GenericRepository;

namespace DaW_Exam.Repositories.AutorRepository
{
    public class AutorRepository : GenericRepository<Autor>, IAutorRepository
    {
        public AutorRepository(AppDatabaseContext appDatabaseContext) : base(appDatabaseContext) { }
        
        public bool CreateDTO(AutorDTO autorDTO)
        {
            var newAutor = new Autor
            {
                Id = Guid.NewGuid(),
                Name = autorDTO.Name,
            };

            Create(newAutor);
            Save();
            return true;
        }
    }
}
