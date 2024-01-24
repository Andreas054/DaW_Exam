using DaW_Exam.Repositories.ExampleRepository;
using DaW_Exam.Services.ExampleService;

namespace DaW_Exam.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IExampleRepository, ExampleRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IExampleService, ExampleService>();

            return services;
        }
    }
}
