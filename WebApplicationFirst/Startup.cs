using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFirst
{
    public class Startup
    {    
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {      
            app.UseRouting();
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Salam ");
            //    await next.Invoke();
            //});
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Bye");
            //});
            app.UseEndpoints(options =>
            {
                options.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
           
        }
    }
}
