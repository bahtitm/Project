using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Project.Infrastructure.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>((sp, options) =>
            {
                options.UseLazyLoadingProxies();
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<AppDbContext>());

            
           


            
            return services;
        }
    }
}
