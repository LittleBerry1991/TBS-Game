﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBS_Game.GameItems.Units;
using TBS_Game.GameItems.UnitsStacks;

namespace TBS_Game.GameItems.Helpers
{
    public static class RandomizeMethods
    {
        static  Random rnd = new Random();  //  -  думаю вот вынести в класс , а то хуле его дергать в методах
        
        // пока максимум игроков 10
        const int limit = 10;

        public static int GetRandomStackSize()
        {
            //Random rnd = new Random();      //   раньше рандомы были в каждом методе
            int result = rnd.Next(limit);
            return result;
        }

        public static int GetRandomDamage(int minDamage, int maxDamage)
        {
            return rnd.Next(minDamage, maxDamage + 1);
        }

        // типа обощеный метод для разных стэков
        public static int GetRandomDamage2(IUnit unit, int unitCount)
        {
            return rnd.Next(unit._MinDamage* unitCount, unit._MaxDamage * unitCount + 1);
        }
        // version # 3 
        public static int GetRandomDamage2(List<IUnit> UnitStack)
        {
            return rnd.Next(UnitStack[0]._MinDamage * UnitStack.Count, UnitStack[0]._MaxDamage * UnitStack.Count + 1);
        }
    }
}
