using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NEMC.BL;
using NEMC.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEMC.WebApi
{
    public static class IoC
    {
        public static ServiceProvider serviceProvider;

        public static T Get<T>() {
            return serviceProvider.GetService<T>();
        }

        public static void AddDependencies(this IServiceCollection services, IConfiguration config) {
            services.AddHttpContextAccessor();

            var connectionString = config.GetConnectionString("NemcDBContext");

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IUnitOfWork>(x => new UnitOfWork(connectionString));
        }
    }
}
