using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace SOET
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Добавление и совместимость MVC с asp.net core 3.0 
            services.AddControllersWithViews()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // Подключаю поддержку статичных файлов в приложение (css, js, etc)
            app.UseStaticFiles();

            // Регистрирую нужный маршрут
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}"); // {id(?)} знак вопроса - НЕОБЯЗАТЕЛЬНЫЙ ПАРАМЕТР
            });
        }
    }
}
