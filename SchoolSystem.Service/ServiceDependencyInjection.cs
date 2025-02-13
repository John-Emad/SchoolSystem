using Microsoft.Extensions.DependencyInjection;
using SchoolSystem.Service.Interfaces;
using SchoolSystem.Service.Services;


namespace SchoolSystem.Service
{
    public static class ServiceDependencyInjection
    {
        public static IServiceCollection InjectingServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            return services;
        }
    }
}
