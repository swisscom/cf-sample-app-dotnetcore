using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace CfSampleAppDotNetCore
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(context =>
            {
                return context.Response.WriteAsync("Congratulations! Welcome to the Swisscom Application Cloud.");
            });
        }
    }
}
