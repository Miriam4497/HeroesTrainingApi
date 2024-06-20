using HeroesTraining.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesTraining.DL
{
    public partial class HeroesTrainingContext:DbContext
    {
        public HeroesTrainingContext()
        {

        }

        public HeroesTrainingContext(DbContextOptions<HeroesTrainingContext> options) : base(options)
        {

        }

        public virtual DbSet<Heroes> Heroes { get; set; }   

        //protected override void onModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Heroes>(entity=>
        //    //entity.Property(e=>e.HeroesId)
        //} 
    }
}
