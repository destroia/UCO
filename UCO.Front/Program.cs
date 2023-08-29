using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCO.Data;
using UCO.Data.Data;
using UCO.Data.Interfaces;

namespace UCO.Front
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }

           
        }
        static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IArtistaData, ArtistaData>().AddScoped<Form1>();
            services.AddDbContext<ContextDbUCO>(
            options => options.UseSqlServer("Data Source=.;Initial Catalog=UCODB;Integrated Security=true")).AddScoped<Form1>(); ;

        }
    }
}
