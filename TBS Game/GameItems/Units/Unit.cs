using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Game.GameItems.Units
{
    public abstract class Unit
    {

        public int HitPoints { get; set; }
        public int Speed { get; set; }
        public Range DamagePoints;//{ get ; set; }        

        public int minD { get; set; }
        public int maxD { get; set; }

    }
    public struct Range
    {
        public int MinDamage;
        public int MaxDamage;
    }
}
