using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Game.GameItems.Units
{
    public class Swordsman : Unit
    {
        protected Type  unitType = Type.Swordsman;
        // а может характеристики сделать статикой ( все равно нада только CurrentTotalHP)
        public Swordsman()
        {
            this.HitPoints = 25;
            this.DamagePoints.MinDamage = 2;
            this.DamagePoints.MaxDamage = 3;
            this.Speed = 3;
        }
    }
}
