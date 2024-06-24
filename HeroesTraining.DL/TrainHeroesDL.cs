using HeroesTraining.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HeroesTraining.DL
{
    public class TrainHeroesDL : ITrainHeroesDL
    {
        private HeroesTrainingContext _trainingContext;

        public HeroesDL(HeroesTrainingContext heroesTrainingContext)
        {
            _trainingContext= heroesTrainingContext;
        }

        public async Task AddTrainHeroes(TrainHeroes trainHeroes)
        {
            try
            {
                await _trainingContext.TrainHeroes.Addasync(trainHeroes);  
                await _trainingContext.SaveChangesAsync();  
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

    }
}