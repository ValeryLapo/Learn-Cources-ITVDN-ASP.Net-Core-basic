using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace _001.GetSection
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
            IConfigurationSection sections = AppConfiguration.GetSection("Company");
            string companyName = sections.GetSection("Name").Value;
            string companyDevelopers = sections.GetSection("Employees").Value;

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync($"<br> {companyName}</br>");
                    await context.Response.WriteAsync($"<br> {companyDevelopers}</br>");
                });
            });
        }
    }
}
