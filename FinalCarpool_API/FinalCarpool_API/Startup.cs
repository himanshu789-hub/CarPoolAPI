using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SimpleInjector;
using SimpleInjector.Integration.AspNetCore.Mvc;
namespace FinalCarpool_API
{
    public class Startup
    {
        Container container = new Container();

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<FinalCarpool_API.Models.CarPoolContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("SqlConnection")));    
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
          container.Options.DefaultScopedLifestyle = new Async;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
