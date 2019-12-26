using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kyr.Interfaces;
using kyr.Mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace kyr
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IPosts, MockPost>();
            services.AddTransient<IReviews, MockReview>();
            services.AddTransient<ITags, MockTag>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(name: "tagFilter", template: "{controller=Second}/{action=List}/{tag?}");
            });
        }
    }
}
