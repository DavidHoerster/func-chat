// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Azure.SignalR.Samples.ChatRoom
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSignalR()
                    .AddAzureSignalR();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
            app.UseFileServer();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseAzureSignalR(routes =>
            {
                routes.MapHub<Chat>("/chat");
            });


            // app.Use(next => async (context) =>
            // {
            //     Globals.ChatHub = context.RequestServices
            //                             .GetRequiredService<IHubContext<Chat>>();
            // });
        }
    }
}
