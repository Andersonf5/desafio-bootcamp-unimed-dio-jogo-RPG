using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Arus
    {
        public Arus(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }


        public string  Name { get; set; }
        public int  Level { get; set; }
        public string  HeroType { get; set; }


        public override string ToString(){
               return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public string Attack (){
            return this.Name + " atacou com a sua espada";
        }
    }
}