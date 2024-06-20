using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesTraining.Entities;


namespace HeroesTraining.DL
{
    public interface IHeroesDL
    {
        Task<List<Heroes>> GetHeroes();
    }
}
