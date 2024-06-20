using AutoMapper;
using HeroesTraining.DL;
using HeroesTraining.DTO;
using HeroesTraining.Entities;


namespace HeroesTraining.BL
{
    public class HeroesBL:IHeroesBL 
    {
        private IMapper _mapper;
        private IHeroesDL _heroesDL;

        public HeroesBL(IMapper mapper, IHeroesDL heroesDL)
        {
            _mapper = mapper;
            _heroesDL = heroesDL;
        }   

        public async Task <List<HeroesDTO>> GetHeroes()
        {
            var HeroestList = await _heroesDL.GetHeroes();
            return _mapper.Map<List<Heroes>,List < HeroesDTO >> (HeroestList);
        }
    }
}