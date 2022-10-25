using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace _001.Memory
{
    public class Startup
    {
        //Property that keeps set of configuration values
        public IConfiguration AppConfiguration { get; set; }

        public Startup()
        {
            //Create configuration builder class instance
            var builder = new ConfigurationBuilder();

            //add new set of values into the collection
            builder.AddInMemoryCollection(new Dictionary<string, string>
            {
                {"Color", "green"},
                {"Content", "Memory configuration is currently shown."}
            });

            AppConfiguration = builder.Build();
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
                    await context.Response.WriteAsync($"<p style='color:{AppConfiguration["Color"]};'>{AppConfiguration["Content"]}</p>");
                });
            });
             
        }
    }
}
