using AutoMapper;
using HeroesTraining.DTO;
using HeroesTraining.Entities;

namespace HeroesTrainingApi
{
    public class AutoMapper : Profile
    {
        public void AutoMapping()
        {
            CreateMap<Heroes, HeroesDTO>();

        }
    }
}
