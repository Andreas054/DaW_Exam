using DaW_Exam.Repositories.AutorRepository;
using DaW_Exam.Repositories.CarteRepository;
using DaW_Exam.Repositories.EdituraRepository;
using DaW_Exam.Repositories.ExampleRepository;
using DaW_Exam.Services.AutorService;
using DaW_Exam.Services.CarteService;
using DaW_Exam.Services.EdituraService;
using DaW_Exam.Services.ExampleService;

namespace DaW_Exam.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IExampleRepository, ExampleRepository>();
            services.AddTransient<IAutorRepository, AutorRepository>();
            services.AddTransient<ICarteRepository, CarteRepository>();
            services.AddTransient<IEdituraRepository, EdituraRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IExampleService, ExampleService>();
            services.AddTransient<IAutorService, AutorService>();
            services.AddTransient<ICarteService, CarteService>();
            services.AddTransient<IEdituraService, EdituraService>();

            return services;
        }
    }
}
