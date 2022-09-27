using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNER_RPG.Models
{
    public class Character
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public int HitPoints {get; set;} = 100;
        public RpgClass Class {get; set;} = RpgClass.knight;
    }
}