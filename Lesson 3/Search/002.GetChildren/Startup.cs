using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _002.GetChildren
{
    public class Startup
    {
        //Property that keeps set of configuration values
        public IConfiguration AppConfiguration { get; set; }

        public Startup(IWebHostEnvironment env)
        {
            //Create configuration builder class instance
            var builder = new ConfigurationBuilder();

            //Set path, from which configuration file search will be produced
            builder.SetBasePath(env.ContentRootPath);

            // Set the name of the configuration file that wil be used
            builder.AddJsonFile("JsonConfig.json");

            // Create configuration
            AppConfiguration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            var sections = AppConfiguration.GetSection("Users");
            var secctionUsers = sections.GetChildren();
            

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    foreach (var section in secctionUsers)
                    {
                        await context.Response.WriteAsync($"<br>{section.Key}: {section.GetSection("Number").Value}</br>");
                    }
                });
            });
        }
    }
}
