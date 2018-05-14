using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SchoolFunderAPI.Filters;

namespace SchoolFunderAPI
{
    public class Startup 
    {
        private readonly int? _httpsPort;

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            if (env.IsDevelopment())
            {
                var launchJsonConfig = new ConfigurationBuilder()
                    .SetBasePath(env.ContentRootPath)
                    .AddJsonFile("Properties\\launchSettings.json")
                    .Build();
                _httpsPort = launchJsonConfig.GetValue<int>("iisSettings:iisExpress:sslPort");
            }
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(opt => {
                opt.Filters.Add(typeof(JsonExceptionFilter));
                opt.SslPort = _httpsPort;
            });

            services.AddRouting(opt => opt.LowercaseUrls = true);

            services.AddApiVersioning(opt => {
                opt.ApiVersionReader = new MediaTypeApiVersionReader();
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.ReportApiVersions = true;
                opt.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                opt.ApiVersionSelector = new CurrentImplementationApiVersionSelector(opt);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseHsts(opt => {
                opt.MaxAge(days: 180);
                opt.IncludeSubdomains();
                opt.Preload();
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
