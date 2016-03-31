using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace EightHair
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder();
            builder.AddEnvironmentVariables();
        }
        
        public void ConfigureServices(IServiceCollection services) => services.AddMvc();
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseIISPlatformHandler(opt => opt.AuthenticationDescriptions.Clear());
            app.UseStaticFiles();
        }
        
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
