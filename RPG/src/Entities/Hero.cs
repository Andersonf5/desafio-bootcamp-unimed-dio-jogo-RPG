using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, string hp, string mp)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.mp = mp;
            this.hp = hp;

        }


        public string  Name { get; set; }
        public int  Level { get; set; }
        public string  HeroType { get; set; }
        public string  mp { get; set; }
        public string  hp { get; set; }


        public string display(){
               return $"{this.Name} \n LV. {this.Level}  {this.HeroType} \n HP  {this.hp} \n MP  {this.mp}\n ___________________\n";
        }

        public virtual string Attack (){
            return this.Name + " atacou com a sua espada";
        }
    }
}