using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.Services
{
    public class Startup
    {
        IServiceCollection Services { get; set; }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            Services = services;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    var html = new StringBuilder();

                    html.Append("<h1 align=center>Services</h1>");
                    html.Append("<table>");
                    html.Append("<tr><th>ServiceType</th><th>Lifetime</th><th>ImplementationType</th></tr>");

                    foreach (var service in Services)
                    {
                        html.Append("<tr>");
                        html.Append($"<td>{service.ServiceType.FullName}</td>");
                        html.Append($"<td>{service.Lifetime}</td>");
                        html.Append($"<td>{service.ImplementationType?.FullName}</td>");
                        html.Append("</tr>");
                    }
                    html.Append("</table>");

                    await context.Response.WriteAsync(html.ToString());
                });
            });
        }
    }
}
