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

namespace _002.Configuration
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
                {"ApplicationName", null},
                {"EnvironmentName", null}
            });

            AppConfiguration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // assign environment values, from which app had been loaded, to the configuration keys
            AppConfiguration["ApplicationName"] = env.ApplicationName;
            AppConfiguration["EnvironmentName"] = env.EnvironmentName;

            string appName = $"<br>ApplicationName: {AppConfiguration["ApplicationName"]}</br>";
            string envName = $"<br>EnvironmentName: {AppConfiguration["EnvironmentName"]}</br>";

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync(appName + envName);
                });
            });
        }
    }
}
