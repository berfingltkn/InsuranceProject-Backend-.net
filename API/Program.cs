using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Autofac;

using Businnes.DependencyResolvers.Autofac;
using API;
using Autofac.Extensions.DependencyInjection;

public class Program
{
    
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
        .UseServiceProviderFactory(new AutofacServiceProviderFactory())
        .ConfigureContainer<ContainerBuilder>(builder =>
        {
            builder.RegisterModule(new AutofacBusinessModule());
        })
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
        });




}