using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NetCoreExample.Business;
using NetCoreExample.Business.Contracts;
using NetCoreExample.Data;
using NetCoreExample.Data.Contracts;

namespace NetCoreExample
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IBusinessEngine, BusinessEngine>();
            services.AddSingleton<IDataRepository, DataRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes =>
            {
                //routes.MapRoute(
                //    name: "goto_one",
                //    template: "one",
                //    defaults: new { controller = "Home", action = "PageOne" });

                //routes.MapRoute(
                //    name: "goto_two",
                //    template: "two/{id?}",
                //    defaults: new { controller = "Home", action = "PageTwo" });

                routes.MapRoute(
                    name: "default",
                    template: "{api}/{controller=Product}/{action=Get}/{id?}");
            });
        }
    }
}
