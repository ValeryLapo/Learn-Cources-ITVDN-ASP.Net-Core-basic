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

namespace _001.Configuration
{
    public class Startup
    {
        //Property that keeps set of app configuration values
        public IConfiguration AppConfiguration { get; set; }

        public Startup()
        {
            //Create configuration builder class instance
            var builder = new ConfigurationBuilder();

            //Add a new set of values to the collection
            builder.AddInMemoryCollection(new Dictionary<string, string>
            {
                {"Name", "Bill"},
                {"Surname", "Gates"}
            });

            AppConfiguration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();


            string name = $"<br>Name: {AppConfiguration["Name"]}</br>";
            string surname = $"<br>Name: {AppConfiguration["Surname"]}</br>";
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync(name + surname);
                });
            });
        }
    }
}
