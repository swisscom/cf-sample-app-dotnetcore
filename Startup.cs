using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using CfSampleAppDotNet.Models;

namespace CfSampleAppDotNetCore
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
