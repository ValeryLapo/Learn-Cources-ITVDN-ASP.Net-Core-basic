using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _001.RoutingInformation
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

            routeBuilder.MapRoute("{controller}/{action}/{id}",
                async context =>
                {
                    RouteData data = context.GetRouteData();

                    foreach (var element in data.Values)
                    {
                        await context.Response.WriteAsync($"<br>{element.ToString()}</br>");
                    }
                });

            //routeBuilder.MapRoute("{controller}/{action}/{id}",
            //    async context =>
            //    {
            //        string controller = context.GetRouteValue("controller").ToString();
            //        string action = context.GetRouteValue("action").ToString();
            //        string id = context.GetRouteValue("id").ToString();
            //        await context.Response.WriteAsync($"<br>{controller}</br>");
            //        await context.Response.WriteAsync($"<br>{action}</br>");
            //        await context.Response.WriteAsync($"<br>{id}</br>");
            //        });


            app.UseRouter(routeBuilder.Build());
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
