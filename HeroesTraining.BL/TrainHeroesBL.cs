using AutoMapper;
using HeroesTraining.DL;
using HeroesTraining.DTO;
using HeroesTraining.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace HeroesTraining.BL
{
    public class TrainHeroesBL: ITrainHeroesBL
    {
        private IMapper _mapper;
        private ITrainHeroesDL _trainHeroesDL;

        public HeroesBL(IMapper mapper, ITrainHeroesDL trainHeroesDL)
        {
            _mapper = mapper;
            _trainHeroesDL = trainHeroesDL;
        }

        public async Task<string> AddTrainHeroes(TrainHeroesDTO trainHeroesDTO);
        {
            try
            {
                var trainHeroes = _mapper.Map<TrainHeroesDTO, TrainHeroesDTO>(trainHeroesDTO);
                await _trainHeroesDL.AddTrainHeroes(trainHeroes);

                trainHeroesDTO.TrainHeroesId=trainHeroes.TrainHeroesId;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}