using System.ComponentModel.DataAnnotations;

namespace HeroesTraining.DTO
{
    public class HeroesDTO
    {
        [Key]
        public int HeroesId { get; set; }

        [MinLength(4)]
        public string HeroesName { get; set; }
        public string Ability { get; set; }

        public DateTime StartDate { get; set; }
        public float StartingPower { get; set; }
        public float CurrentPower { get; set; }
        public int TrainerId { get; set; }
    }
}