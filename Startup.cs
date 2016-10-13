using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using CfSampleAppDotNetCore.Models;

namespace CfSampleAppDotNetCoreCore
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddSingleton<IKittenRepository, KittenRepository>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}
