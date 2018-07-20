using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Game.GameItems.Units
{
    public class Swordsman : IUnit
    {
        protected Type unitType = Type.Swordsman;
        public static int HitPoints = 25;
        public int _HitPoints
        {
            get { return HitPoints; }
            set { _HitPoints = HitPoints; }
        }

        public static int Speed = 3;
        public int _Speed
        {
            get { return Speed; }
            set { _Speed = Speed; }
        }

        public static int MinDamage = 2;
        public int _MinDamage
        {
            get { return MinDamage; }
            set { _MinDamage = MinDamage; }
        }

        public static int MaxDamage = 2;
        public int _MaxDamage
        {
            get { return MaxDamage; }
            set { _MaxDamage = MaxDamage; }
        }
    }
}
