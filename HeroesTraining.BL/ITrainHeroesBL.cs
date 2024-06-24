using HeroesTraining.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesTraining.BL
{
    public interface IHeroesBL
    {
        Task AddTrainHeroes(TrainHeroesDTO trainHeroesDTO);
    }
}
