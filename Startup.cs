using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using PersonRepository.Repositories.impl;
using RestApiDOTNETCore.Data;
using RestApiDOTNETCore.Repositories;
using RestApiDOTNETCore.Services;
using RestApiDOTNETCore.Services.impl;

namespace RestApiDOTNETCore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<DataBaseContext,DataBaseContext>();
            services.AddScoped<IPersonService,PersonServiceImpl>();
            services.AddTransient<IPersonRepository,PersonRepositoryImpl>();

            services.AddMvc();

            services.AddApiVersioning();

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(config => {
               config.AllowAnyHeader();
               config.AllowAnyMethod();
               config.AllowAnyOrigin();
           });

            app.UseMvc();

        }
    }
}
