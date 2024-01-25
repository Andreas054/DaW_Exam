using DaW_Exam.Data;
using DaW_Exam.Models;
using DaW_Exam.Models.DTOs;
using DaW_Exam.Models.Many_to_Many;
using DaW_Exam.Repositories.GenericRepository;

namespace DaW_Exam.Repositories.EdituraRepository
{
    public class EdituraRepository : GenericRepository<Editura>, IEdituraRepository
    {
        public EdituraRepository(AppDatabaseContext appDatabaseContext) : base(appDatabaseContext) { }

        public bool CreateDTO(EdituraDTO edituraDTO)
        {
            var newEditura = new Editura
            {
                Id = Guid.NewGuid(),
                Judet = edituraDTO.Judet,
            };

            Create(newEditura);
            Save();
            return true;
        }
    }
}
