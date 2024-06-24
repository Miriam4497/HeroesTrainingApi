using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using AutoMapper;
using HeroesTraining.Entities;
using HeroesTraining.DL;
using HeroesTraining.BL;
using HeroesTraining.DTO;



namespace HeroesTrainingApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));

            services.AddScoped<IHeroesBL, HeroesBL>;
            services.AddScoped<IHeroesDL, HeroesDL>;

            services.AddScoped<ITrainHeroesBL, TrainHeroesBL>;
            services.AddScoped<IHeroesDL, HeroesDL>;

            services.AddValidatorsFromAssemblyContaining<GetTokenRequestValidator>();


        }

        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}
