using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UCO.Data;

namespace UCO.Api
{
    public static class DependencyContainer
    {
        public static IServiceCollection DependencyServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.DependencyData(configuration);
            return services;
        }
    }
}
