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

namespace _002.Routing
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

            //Define route handlers
            var myRouteHandlerHome = new RouteHandler(HandleHome);
            var myrouteHandlerHomeCources = new RouteHandler(HandleHomeCources);

            //Create routes using handlers
            var routeBuilerHome = new RouteBuilder(app, myRouteHandlerHome);
            var routeBuilerHomeCources = new RouteBuilder(app, myrouteHandlerHomeCources);

            // Definition of the routes - they should match the specified static patterns
            routeBuilerHome.MapRoute("default", "Home");
            routeBuilerHomeCources.MapRoute("default", "Home/Courses");

            //Build routes
            app.UseRouter(routeBuilerHome.Build());
            app.UseRouter(routeBuilerHomeCources.Build());

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Default page.");
                });
            });
        }

        private async Task HandleHome(HttpContext context)
        {
            await context.Response.WriteAsync("Hope page.");
        }

        private async Task HandleHomeCources(HttpContext context)
        {
            StringCollection cources = new StringCollection()
            {
                "C# starter",
                "C# Essential",
                "C# Professional",
                "C# Patterns of Design"
            };

            await context.Response.WriteAsync("Here is the list of the available courses:");

            foreach (var course in cources)
            {
                await context.Response.WriteAsync($"<br>{course}</br>");
            }
        }

    }
}
