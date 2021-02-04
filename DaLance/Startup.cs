using DaLance.Domain.Repositories;
using DaLance.Domain.Services;
using DaLance.Entity;
using DaLance.Entity.Repositories;
using DaLance.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaLance
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
            services.AddRazorPages().AddRazorRuntimeCompilation();

            services.AddControllersWithViews();

            services.AddDbContext<DaLanceContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("WebContext"),
                    assembly => assembly.SetPostgresVersion(new Version(9, 6)));
            });


            //Declaração das interfaces de cada classe, essencial para o uso do singleton
            //Repository
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<ILanceRepository, LanceRepository>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            //Services
            services.AddTransient<IProdutoService, ProdutoService>();
            services.AddTransient<ILanceService, LanceService>();
            services.AddTransient<IUsuarioService, UsuarioService>();

            services.AddCors(option =>
            {
                option.AddPolicy("allowedOrigin",
                    builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
                    );
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
