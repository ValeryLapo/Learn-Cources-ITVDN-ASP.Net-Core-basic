using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _003.HttpRequestTypes
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            var routeBuilder = new RouteBuilder(app);

            //routeBuilder.MapGet("{controller}/{action}/{id}",
            //    async context =>
            //    {
            //        await context.Response.WriteAsync("GET request by this route is proceeded.");
            //    });

            routeBuilder.MapPost("{controller}/{action}/{id}",
                async context =>
                {
                    await context.Response.WriteAsync("GET request by this route is proceeded.");
                });

            app.UseRouter(routeBuilder.Build());
            app.UseRouting();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Default page.");
            });
        }

    }
}
