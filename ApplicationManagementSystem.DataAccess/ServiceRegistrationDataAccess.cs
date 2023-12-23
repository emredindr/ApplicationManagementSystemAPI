using ApplicationManagementSystem.DataAccess.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationManagementSystem.DataAccess
{
    public static class ServiceRegistrationDataAccess
    {
        public static void AddDbConnectionServices(this IServiceCollection services)

        {
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(Configuration.ConnectionString));          
        }
    }
}