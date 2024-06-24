namespace HeroesTraining.Entities
{
    public  partial class TrainHeroes
    {

        public int TrainHeroesId { get; set; }

        public DateTime Date { get; set; }

        public int NumberTrainer { get; set; }

        public  virtual HeroesId HeroesId { get; set; }

    }
}