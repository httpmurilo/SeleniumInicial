using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjetoSelenium.Core;
using ProjetoSelenium.Core.Interfaces;
using ProjetoSelenium.Dados;
using ProjetoSelenium.Dados.Interfaces;
using ProjetoSelenium.Dados.Repositorio;

namespace ProjetoSelenium.WebApp {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services)
         {
            services.AddDbContext<LeiloesContext> (options => {
                options.UseSqlServer (Configuration.GetConnectionString ("ConexaoSQL"), b => b.MigrationsAssembly("ProjetoSelenium.WebApp"));
            });
            services.AddTransient<IModalidadeAvaliacao, MaiorValor> ();
            services.AddTransient<IRepositorio<Leilao>, RepositorioLeilao> ();
            services.AddTransient<IRepositorio<Interessada>, RepositorioInteressada> ();
            services.AddTransient<IRepositorio<Usuario>, RepositorioUsuario> ();
            services.AddSession ();
           // services.AddMvc ()
           services.AddMvc(option => option.EnableEndpointRouting = false);
        }
        public void Configure (IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            } else {
                app.UseExceptionHandler ("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts ();
            }

            app.UseStaticFiles ();
            app.UseSession();
            app.UseMvcWithDefaultRoute();
        }
    }
}