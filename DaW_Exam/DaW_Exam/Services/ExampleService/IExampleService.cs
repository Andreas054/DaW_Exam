using DaW_Exam.Models;

namespace DaW_Exam.Services.ExampleService
{
    public interface IExampleService
    {
        public Example GetById(Guid id);
    }
}
