using Infrastructure.DomainModel.Identity;
using Infrastructure.Persistence.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation.Endpoint.Infrastructure.Configurations
{
    public static class IdentityConfigurationExtensions
    {
        public static void AddCustomIdentity(this IServiceCollection services/*, IdentitySettings settings*/)
        {
            services.AddIdentity<ApplicationUser, ApplicationRole>(identityOptions =>
            {
                //Password Settings
                identityOptions.Password.RequireDigit = false;           /* settings.PasswordRequireDigit;*/
                identityOptions.Password.RequiredLength = 5;       /* settings.PasswordRequiredLength;*/
                identityOptions.Password.RequireNonAlphanumeric = false;  /* settings.PasswordRequireNonAlphanumic; //#@!*/
                identityOptions.Password.RequireUppercase = false;       /* settings.PasswordRequireUppercase;*/
                identityOptions.Password.RequireLowercase = false;      /* settings.PasswordRequireLowercase;*/

                //UserName Settings
                identityOptions.User.RequireUniqueEmail = true;         /* settings.RequireUniqueEmail;*/

                //Singin Settings
                //identityOptions.SignIn.RequireConfirmedEmail = false;
                //identityOptions.SignIn.RequireConfirmedPhoneNumber = false;

                //Lockout Settings
                //identityOptions.Lockout.MaxFailedAccessAttempts = 5;
                //identityOptions.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                //identityOptions.Lockout.AllowedForNewUsers = false;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();
        }
    }
}
