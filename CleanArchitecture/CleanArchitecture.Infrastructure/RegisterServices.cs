using CleanArchitecture.Application.Repositories.EmployeeRepository;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure
{
    public static class RegisterServices
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository.EmployeeRepository>();
            return services;
        }
    }
}
