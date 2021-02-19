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
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

            // Inyección del contexto:
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

            // Swagger
            AddSwagger(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Foo API V1");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("CorsPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }


        private void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                var groupName = "v1";

                options.SwaggerDoc(groupName, new OpenApiInfo
                {
                    Title = $"LaCochera {groupName}",
                    Version = groupName,
                    Description = "LaCochera API",
                    Contact = new OpenApiContact
                    {
                        Name = "Piccasoft Coop.",
                        Email = "a_miguel.moreno.jurado@iespablopicasso.es",
                        Url = new Uri("http://lacochera.test/"),
                    }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);
            });
        }
    }
}
