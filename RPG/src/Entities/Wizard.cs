using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Wizard : Hero
    {

        public Wizard (string Name, int Level, string HeroType, string mp, string hp) : base(Name,Level,HeroType,mp,hp)
        {

        }
  

        public override string Attack (){
            return this.Name + " lançou magia";
        }        

        public string Attack (int bonus){

            if (bonus>6)
            {
               return this.Name + " lançou uma magia super efetiva com bônus "+bonus; 

            }else{
                return this.Name + " lançou uma magia fraca com bônus "+bonus; 
            }
            
        } 
    }
}