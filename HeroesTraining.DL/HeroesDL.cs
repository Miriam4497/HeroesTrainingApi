using HeroesTraining.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HeroesTraining.DL
{
    public class HeroesDL:IHeroesDL  
    {
        private HeroesTrainingContext _trainingContext;

        public HeroesDL(HeroesTrainingContext heroesTrainingContext)
        {
            _trainingContext= heroesTrainingContext;
        }

        public async Task<List<Heroes>> GetHeroes()
        {
            return await _trainingContext.Heroes.ToListAsync();
        }

    }
}