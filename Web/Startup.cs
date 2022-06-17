using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;
using Infrastructure.UnitOfWork;

namespace Portfolio
{

    public class Startup
    {
        private readonly IConfiguration configuration;
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<DataDbContext>(options =>
                    options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting(); 
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                   name: "AdministratorArea",
                   areaName: "Administrator",
                   pattern: "Administrator/{controller=Home}/{action=Index}"); //This is Administrator route. You can you {id} and other parameters which you want

                endpoints.MapControllerRoute(
                    name: "defaultRoute",
                    pattern: "{controller=Home}/{action=Index}/{id?}"); // This route is for Controllers which are situated in project controller folder
            });
        }
    }
}
