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

namespace _002.DefaultParameters
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

            routeBuilder.MapRoute("{controller=Home}/{action}/{id}",
                async context =>
                {
                    await context.Response.WriteAsync("{controller}/{action}/{id} template used");
                });
            routeBuilder.MapRoute("Test/{action}/{id}",
                async context =>
                {
                    await context.Response.WriteAsync("Test/{action}/{id} template used");
                });


            app.UseRouter(routeBuilder.Build());
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Deafult page.");
                });
            });
        }
    }
}
