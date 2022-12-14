using CERAXLAN.Core.Security.EmailAuthenticator;
using CERAXLAN.Core.Security.JWT;
using CERAXLAN.Core.Security.OtpAuthenticator;
using CERAXLAN.Core.Security.OtpAuthenticator.OtpNet;
using Microsoft.Extensions.DependencyInjection;

namespace CERAXLAN.Core.Security
{
    public static class SecurityServiceRegistration
    {
        public static IServiceCollection AddSecurityServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenHelper, JwtHelper>();
            services.AddScoped<IEmailAuthenticatorHelper, EmailAuthenticatorHelper>();
            services.AddScoped<IOtpAuthenticatorHelper, OtpNetOtpAuthenticatorHelper>();
            return services;
        }
    }
}
