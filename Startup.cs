using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BackEndFoundationsCSharp{
    public class Startup{
        public IConfiguration Configuration{get;}
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
            // This method gets called by the runtime. Use this method to add services to the container.
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
            //This method was written using a sample from Steve Bishop's GitHub.
            //For more info about the repo, visit https://github.com/Xipooo/ASPNETCoreDemo/blob/MVC/Startup.cs
        public void ConfigurationServices(IServiceCollection services)
        {
            services.AddMvc();
        }
            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void configure(IApplicationBuilder application, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                application.UseDeveloperExceptionPage();
            }
            application.UseMvc();
        }
    }
}