using DDRScoring.Data;
using DDRScoring.Data.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<StoreUser, IdentityRole>(cfg =>
            {
                cfg.User.RequireUniqueEmail = true;
                cfg.ClaimsIdentity.UserIdClaimType = "UserID";
            }).AddEntityFrameworkStores<DDRScoringContext>();
            services.AddAuthentication(cfg =>
            {
                cfg.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                cfg.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                cfg.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(cfg =>
                {
                    cfg.SaveToken = true;
                    cfg.RequireHttpsMetadata = false;
                    cfg.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidIssuer = _config["Tokens:Issuer"],
                        ValidAudience = _config["Tokens:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]))
                    };
                });
            services.AddDbContext<DDRScoringContext>(cfg =>
            {
                cfg.UseSqlServer(_config["ConnectionStrings:DDRScoringContextDb"]);
            });
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient<DDRScoringSeeder>();
            services.AddTransient<IDDRScoringRepository, DDRScoringRepository>();
            services.AddRazorPages();
            services.AddControllers().AddXmlSerializerFormatters();
        }

        private void AddServiceRepository(IServiceCollection services)
        {
            services.AddTransient<IPlayerRepository, PlayerRepository>();
            services.AddTransient<IStepsRepository, StepsRepository>();
            services.AddTransient<ISongRepository, SongRepository>();
            services.AddTransient<IHighScoreRepository, HighScoreRepository>();
            services.AddTransient<IHighScoreListRepository, HighScoreListRepository>();
            services.AddTransient<IRadarValuesRepository, RadarValuesRepository>();
            services.AddTransient<ITapNoteScoresRepository, TapNoteScoresRepository>();
            services.AddTransient<ICaloriesBurnedRepository, CaloriesBurnedRepository>();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute("Default",
                "/{controller}/{action}/{id?}",
                new { controller = "App", action = "Index" });

            });
        }
    }
}
