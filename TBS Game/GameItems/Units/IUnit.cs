using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Game.GameItems.Units
{
    public interface IUnit
    {
        int _HitPoints { get; set; }
        int _Speed { get; set; }
        int _MinDamage { get; set; }
        int _MaxDamage { get; set; }
    }
}
