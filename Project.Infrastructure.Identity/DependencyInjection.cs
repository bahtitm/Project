using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace Project.Infrastructure.Identity
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IdentityDbContext>((sp, options) =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });




            //services.Configure<PasswordValidationOptions>(configuration.GetSection("IdentityOptions:PasswordValidation"));

            services.AddDefaultIdentity<ApplicationUser>()
                    //.AddErrorDescriber<MultilanguageIdentityErrorDescriber>()
                    //.AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<IdentityDbContext>();
                    //.AddUserManager<ApplicationUserManager<ApplicationUser>>()
                    //.AddPasswordValidator<PasswordContainsUserNameValidator>()
                    //.AddPasswordValidator<LastPasswordsRestrictionValidator>()
                    //.AddDefaultTokenProviders();

           // services.AddIdentityServer4(configuration);

            return services;
        }
    }
}
