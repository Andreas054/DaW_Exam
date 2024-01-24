using DaW_Exam.Models;
using DaW_Exam.Repositories.GenericRepository;

namespace DaW_Exam.Repositories.ExampleRepository
{
    public interface IExampleRepository : IGenericRepository<Example>
    {
        public Example FindById(Guid id);
    }
}
