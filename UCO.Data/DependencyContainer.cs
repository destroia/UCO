using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCO.Data.Data;
using UCO.Data.Interfaces;

namespace UCO.Data
{
    public static class DependencyContainer
    {
        public static IServiceCollection DependencyData(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ContextDbUCO>( options => options.UseSqlServer(configuration.GetConnectionString("ConnectionMain")));

            services.AddScoped<IArtistaData, ArtistaData>();
            services.AddScoped<ICancionData, CancionData>();

            return services;
        }
    }
}
