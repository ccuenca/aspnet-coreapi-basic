using AutoMapper;
using ConceptosService2.BusinessLogic.Conceptos;
using ConceptosService2.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConceptosService2
{
    public class Startup
    {
        private IConfiguration Configuration { get; }


        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SiamContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Db")));

            services.AddTransient<IConceptosBL, ConceptosBL>();

            services.AddAutoMapper();

            services.AddMvc();

            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, SiamContext dbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //if (env.IsDevelopment())
            //{
            //    dbContext.EnsureSeedData();
            //}

            app.UseMvcWithDefaultRoute();
        }
    }
}
