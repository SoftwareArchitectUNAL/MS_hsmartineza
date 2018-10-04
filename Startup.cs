using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntidadesApi.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;


namespace EntidadesApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            //Configuration = configuration;
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EntidadContext>(opt => opt.UseMySQL(Configuration.GetConnectionString("DbEntidades")));
            services.AddScoped<IEntidadRepository, EntidadRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
