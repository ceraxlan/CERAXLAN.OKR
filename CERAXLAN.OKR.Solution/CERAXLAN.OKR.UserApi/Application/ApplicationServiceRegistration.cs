using CERAXLAN.Core.Application.Pipelines.Transaction;
using CERAXLAN.Core.Application.Pipelines.Validation;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Rules;
using CERAXLAN.OKR.UserApi.Application.Services.UserService;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Reflection;

namespace CERAXLAN.OKR.UserApi.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped<UserBusinessRules>();

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CachingBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CacheRemovingBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
            
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(TransactionScopeBehavior<,>));

            services.AddScoped<IUserService, UserService>();

            return services;

        }
    }
}
