using CERAXLAN.OKR.UserApi.Application.Services.Repositories;
using CERAXLAN.OKR.UserApi.Persistence.Repositories;

namespace CERAXLAN.OKR.UserApi.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
