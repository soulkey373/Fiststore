
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using NSwag;
using NSwag.Generation.Processors.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backstage.Models;
using Backstage.Services;
using Backstage.Interfaces;

namespace Backstage
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
            services.AddDbContext<RentContext>(options => options.UseSqlServer(Configuration.GetConnectionString("RentContext")));
            services.AddTransient<IAnalysisService, AnalysisService>();
            services.AddTransient<IBlogService, BlogService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOrderService, OrderService>();


            //��Swagger�䴩JWT
            services.AddSwaggerDocument(config =>
            {
                var apiScheme = new OpenApiSecurityScheme()
                {
                    Type = OpenApiSecuritySchemeType.ApiKey,
                    Name = "Authorization",
                    In = OpenApiSecurityApiKeyLocation.Header,
                    Description = "�бNToken��J : Bearer {token}"
                };
                config.AddSecurity("JWT Token", Enumerable.Empty<string>(), apiScheme);
                config.OperationProcessors.Add(
                    new AspNetCoreOperationSecurityScopeProcessor("JWT Token"));
            });

            //���U ����ˬdtoken
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
              .AddJwtBearer(
                  option =>
                  {
                      option.IncludeErrorDetails = true;

                      option.TokenValidationParameters = new TokenValidationParameters
                      {
                          //Marvin�G�[�o��~���o��identity.name
                          NameClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifiers",
                          ValidateIssuer = true, //�o���
                          ValidIssuer = "RentWeb",  //�o��̱o�M�o�Үɪ��o��̤@��
                          ValidateAudience = false,
                          ValidateLifetime = true, 
                          IssuerSigningKey =    //Signingkey�o�M���_�@��
                              new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1Zl4h9703IzROidasgfegkK3@f4po1jkd"))
                      };

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
            app.UseStaticFiles();// �ϥ��R�A�ɮסA���\�{��Ū��wwwroot���ɮ�
            //�ҥ�Swagger
            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseRouting();

            //�ҥ����ҡA�����b���v�e
            app.UseAuthentication();
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