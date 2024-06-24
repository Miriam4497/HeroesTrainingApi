using System.ComponentModel.DataAnnotations;

namespace HeroesTraining.Entities
{
    public  partial class TrainHeroesDTO
    {
        [Key]
        public int TrainHeroesId { get; set; }

        public DateTime Date { get; set; }

        public int NumberTrainer { get; set; }

        public virtual HeroesId HeroesId { get; set; }

    }
}