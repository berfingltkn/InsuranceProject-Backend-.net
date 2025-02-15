﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //Bu method ile dependency injection yapılandırması yapabiliriz, fakat bunun yerine autofac yapılandırması tercih edilebilir.
        public void ConfigureServices(IServiceCollection services)
        {

            // Hizmetleri yapılandırma
            services.AddControllers();
            services.AddCors();

            // var tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //   .AddJwtBearer(options =>
            //   {
            //       options.TokenValidationParameters = new TokenValidationParameters
            //       {
            //           ValidateIssuer = true,
            //           ValidateAudience = true,
            //           ValidateLifetime = true,
            //           ValidIssuer = tokenOptions.Issuer,
            //           ValidAudience = tokenOptions.Audience,
            //           ValidateIssuerSigningKey = true,
            //           IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
            //       };
            //   });

            //  services.AddDependencyResolvers(new ICoreModule[]
            //{
            //      new CoreModule()
            //});
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }




            app.UseCors(builder => builder.WithOrigins("http://localhost:3000").AllowAnyHeader());
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

    }
}
