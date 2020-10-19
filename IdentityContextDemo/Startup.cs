using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoEntity.Data;
using DemoEntity.Implementation;
using DemoEntity.Interface;
using DemoRepository.Implementation;
using DemoRepository.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace IdentityContextDemo
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
            services.AddControllersWithViews();
            services.AddDbContext<traffictraineesContext>(options => options.UseSqlServer("Data Source=n6.iworklab.com;Initial Catalog=traffic-trainees;Persist Security Info=True;User ID=traffic-trainees;Password=TR32D9aWJRUS20#"));
            //services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<traffictraineesContext>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IEntityUsers, EntityUsers>();
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
                endpoints.MapControllers();
                //Route(
                //    name: "default",
                //    pattern: "{controller=Book}/{action=Index}/{id?}");
            });
        }
    }
}
