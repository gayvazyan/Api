using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Services.Locations;
using ElectionAPI.Context;
using ElectionAPI.Model;
using ElectionAPI.Repository;
using ElectionAPI.Services.Community;
using ElectionAPI.Services.Election;
using ElectionAPI.Services.Region;
using ElectionAPI.Services.SubDistrict;
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

namespace ElectionAPI
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
            services.AddMvc();
            // services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version="Տարբերակ 1․0․1",
                    Title="Election API",
                    Description="Սերվիսները նախատեսված են տվյալների ստացում ըստ պահանջի և անհրաժեշտության կատարվող հաշվարկների հիման վրա։ Հարցերի դեպքում դիմել ԿԸՀ ՏՏ և ՏՎ վարչություն։ "
                });
            });
            services.AddDbContext<ElectionsDbContext>(options =>
                       options.UseSqlServer(Configuration.GetConnectionString("ElectionsDbConnection")));

            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            services.AddTransient<ILocationService, LocationService>();

            /////////////-----------Old-------------/////////////
            //services.AddTransient<IElectionService, ElectionService>();
            //services.AddTransient<ISubDistrictService, SubDistrictService>(); 
            //services.AddTransient<IRegionService, RegionService>(); 
            //services.AddTransient<ICommunityService, CommunityService>(); 
        }
        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c=> 
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json","ElectionAPI");
                c.RoutePrefix = string.Empty;
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
