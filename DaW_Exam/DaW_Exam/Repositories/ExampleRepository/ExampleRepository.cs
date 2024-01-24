using DaW_Exam.Data;
using DaW_Exam.Models;
using DaW_Exam.Repositories.GenericRepository;

namespace DaW_Exam.Repositories.ExampleRepository
{
    public class ExampleRepository : GenericRepository<Example>, IExampleRepository
    {
        public ExampleRepository(AppDatabaseContext appDatabaseContext) : base(appDatabaseContext) { }

        public Example FindById(Guid id)
        {
            return _table.FirstOrDefault(ex => ex.Id.Equals(id));
        }
    }
}
