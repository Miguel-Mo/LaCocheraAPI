using AutoMapper;
using LaCochera.BL.Contracts;
using LaCochera.BL.Implementations;
using LaCochera.DAL.Models;
using LaCochera.DAL.Repositories;
using LaCochera.DAL.Repositories.Contracts;
using LaCochera.DAL.Repositories.Implementations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaCochera.API
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

            services.AddControllersWithViews()
                .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

            // Automapper
            services.AddAutoMapper(typeof(MappingProfile));

            // Para habilitar CORS en nuestra API
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            // Inyecci�n del contexto:
            services.AddDbContext<CocherabbddContext>(opts => opts.UseMySql(Configuration["ConnectionString:CocheraDB"]));

            // Procedemos a inyectar dependencias:
            services.AddScoped<ILoginBL, LoginBL>();
            services.AddScoped<ILoginRepository, LoginRepository>();

            services.AddScoped<IMecanicosRepository, MecanicosRepository>();
            services.AddScoped<IMecanicosBL, MecanicosBL>();

            services.AddScoped<IVendedoresRepository, VendedoresRepository>();
            services.AddScoped<IVendedoresBL, VendedoresBL>();

            services.AddScoped<IReparacionesRepository, ReparacionesRepository>();
            services.AddScoped<IReparacionesBL, ReparacionesBL>();

            services.AddScoped<IPropuestaVentaRepository, PropuestaVentaRepository>();
            services.AddScoped<IPropuestasVentaBL, PropuestasVentaBL>();

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioBL, UsuarioBL>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("CorsPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
