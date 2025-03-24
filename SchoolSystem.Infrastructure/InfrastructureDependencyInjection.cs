using Microsoft.Extensions.DependencyInjection;
using SchoolSystem.Infrastructure.Generics;
using SchoolSystem.Infrastructure.Interfaces;
using SchoolSystem.Infrastructure.Repositories;

namespace SchoolSystem.Infrastructure
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection InjectingInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();
            return services;
        }

    }
}
