using Microsoft.Extensions.DependencyInjection;
using SchoolSystem.Infrastructure.Interfaces;
using SchoolSystem.Infrastructure.Repositories;

namespace SchoolSystem.Infrastructure
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection InjectingInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();
            return services;
        }

    }
}
