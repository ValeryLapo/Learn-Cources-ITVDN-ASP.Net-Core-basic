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

namespace _002.Constrains
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
            //define route handler
            var myRouteHandler = new RouteHandler(Handle);

            //Createroute using handler
            var routeBuilder = new RouteBuilder(app, myRouteHandler);

            //Definition of the route itself - he have to match given template and constrain.
            //routeBuilder.MapRoute("default", "{controller}/{action}/{id?}", null, new {action = "Index"});

            //routeBuilder.MapRoute("default", "{controller}/{action}/{id?}", null, new { controller = "^H.*", id = @"\d{2}" });

            routeBuilder.MapRoute("default", "{controller}/{action}/{id?}", null, new { id = new BoolRouteConstraint()});

            app.UseRouter(routeBuilder.Build());
            app.UseRouting();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Default page.");
            });
        }

        private async Task Handle(HttpContext context)
        {
            await context.Response.WriteAsync("The route is chosen.");
        }
    }
}
