using Microsoft.AspNetCore.Builder;
using AutoMapper;
using HeroesTrainingApi.dto;

namespace HeroesTrainingApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddControllers();
        //    services.AddAutoMapper();

        //    services.AddScoped<IHeroesBL, HeroesBL>;

        //}

        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}
