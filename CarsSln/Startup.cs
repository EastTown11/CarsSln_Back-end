
using CarsSln.Model;
using CarsSln.Service.CarCompanyService;
using CarsSln.Service.CarComponentService;
using CarsSln.Service.CarInfoService;
using CarsSln.Service.CarModelsService;
using CarsSln.Service.CarTypeService;
using CarsSln.Service.ColorCarService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CarsSln
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CarsSln", Version = "v1" });
            });
            services.AddDbContext<Car_SContext>(x => x.UseSqlServer(Configuration.GetConnectionString("CarsConnection")));
            services.AddScoped<ICarInfoService, CarInfoService>();
            services.AddScoped<ICarColorService, CarColorService>();
            services.AddScoped<ICarCompanyService, CarCompanyService>();
            services.AddScoped<ICarComponentService, CarComponentService>();
            services.AddScoped<ICarTypeService ,CarTypeService > ();
            services.AddScoped<ICarColorService, CarColorService>();
            services.AddScoped<ICarModelServices, CarModelsService>();
         
            services.AddCors();
          

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CarsSln v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        
    }
}
