using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Game.GameItems.Units
{
    public class Peasant : IUnit
    {
        protected Type unitType = Type.Peasant;

        public Peasant()
        {
            this.HitPoints = 15;
            this.DamagePoints.MinDamage = 2;
            this.DamagePoints.MaxDamage = 4;
            this.Speed = 5;
        }
    }
}
