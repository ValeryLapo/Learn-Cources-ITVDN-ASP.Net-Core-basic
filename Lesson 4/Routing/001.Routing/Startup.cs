using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace _001.Routing
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Add Rounting service
            services.AddRouting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            var routeBuilder = new RouteBuilder(app);

            routeBuilder.MapRoute("Home",
                async context =>
                {
                    await context.Response.WriteAsync("Home page.");
                });

            routeBuilder.MapRoute("Home/Cources",
                async context =>
                {
                    var cources = new StringCollection()
                    {
                        "C# starter",
                        "C# Essential",
                        "C# Professional",
                        "C# Patterns of Design"
                    };

                    await context.Response.WriteAsync("Here is the list of the available courses:<br></br>");

                    foreach (var course in cources)
                    {
                        await context.Response.WriteAsync($"<br>{course}</br>");
                    }
                });


            app.UseRouter(routeBuilder.Build());

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Defauilt page");
                });
            });
        }
    }
}
