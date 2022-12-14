using CERAXLAN.OKR.ProductApi.Application.Services.Repositories;
using CERAXLAN.OKR.ProductApi.Persistence.Repositories;

namespace CERAXLAN.OKR.ProductApi.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<ProductContext>(options =>options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
