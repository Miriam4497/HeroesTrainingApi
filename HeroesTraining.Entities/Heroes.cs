namespace HeroesTraining.Entities
{
    public  partial class Heroes
    {

        public int HeroesId { get; set; }
        public string HeroesName { get; set; }
        public string Ability { get; set; }

        public DateTime StartDate { get; set; }
        public float StartingPower { get; set; }
        public float CurrentPower { get; set; }
        public  virtual Trainer Trainer { get; set; }

    }
}