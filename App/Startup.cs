using System;
using System.Globalization;
using System.IO;
using App.Customizations.ModelBinders;
using App.Models.Options;
using App.Models.Services.Application;
using App.Models.Services.Application.Docenti;
using App.Models.Services.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace App
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => 
            {
                options.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
            });

            services.AddRazorPages();
            //services.AddControllersWithViews(); Questo non è necessario in quanto è già presente la dichiarazione services.AddMvc alla riga 30

            //Database
            services.AddDbContextPool<FormazioneDbContext>(optionsBuilder => {
                string connectionString = Configuration.GetSection("ConnectionStrings").GetValue<string>("Default");
                optionsBuilder.UseSqlServer(connectionString, options => 
                {
                    options.EnableRetryOnFailure(3);
                });
            });

            services.AddSingleton<IErrorViewSelectorService, ErrorViewSelectorService>();
            services.AddTransient<IDocentiService, EfCoreDocentiService>();
            
            //Options
            services.Configure<DocenteOptions>(Configuration.GetSection("Docente"));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime lifetime)
        {
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();

                lifetime.ApplicationStarted.Register(() =>
                {
                    string filePath = Path.Combine(env.ContentRootPath, "bin/reload.txt");
                    File.WriteAllText(filePath, DateTime.Now.ToString());
                });
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            CultureInfo appCulture = new("it-IT");

            app.UseStaticFiles();
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(appCulture),
                SupportedCultures = new[] { appCulture }
            });

            app.UseRouting();

            // Righe non necessarie
            // app.UseEndpoints(endpoints => 
            // {
            // endpoints.MapRazorPages();
            // });

            app.UseEndpoints(routeBuilder =>
            {
                routeBuilder.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                routeBuilder.MapFallbackToController("{*path}", "Index", "Error");
                routeBuilder.MapRazorPages();
            });
        }
    }
}
