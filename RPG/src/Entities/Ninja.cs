using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja (string Name, int Level, string HeroType, string mp, string hp) : base(Name,Level,HeroType,mp,hp)
        {
            
        }

        public override string Attack (){
            return this.Name + " lançou uma estrela";
        }   
    }
}