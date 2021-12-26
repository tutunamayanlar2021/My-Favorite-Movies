using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using OrnekPro.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekPro
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MovieContext>(options =>
           // options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
           options.UseSqlServer(Configuration.GetConnectionString("MsSQLConnection")));
            
            services.AddLocalization(opt => { opt.ResourcesPath = "Resources"; }) ;
            services.AddMvc()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();
            services.Configure<RequestLocalizationOptions>(opt =>
            {
            var dil_destegi = new []
                { 
                new CultureInfo("en"),
                new CultureInfo("es"),
                new CultureInfo("tr"),
                };
                opt.DefaultRequestCulture = new RequestCulture(culture:"tr",uiCulture:"tr");
                opt.SupportedCultures = dil_destegi;
                opt.SupportedUICultures = dil_destegi;


            });
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                StaticMovies.theOriginals(app);
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseRequestLocalization(app.ApplicationServices
                .GetRequiredService<IOptions<RequestLocalizationOptions>>()
                .Value);

            
        
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "about",
                    pattern: "{controller=Home}/{action=About}/{id?}");
                endpoints.MapControllerRoute(
                   name: "movieList",
                   pattern: "{controller=Movies/List}/{action=List}/{id?}");
                endpoints.MapControllerRoute(
               name: "movie",
               pattern: "{controller=Movies/Details}/{action=Details}/{id?}");

            });
        }
    }
}
