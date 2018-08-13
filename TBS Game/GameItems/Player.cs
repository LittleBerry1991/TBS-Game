using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBS_Game.GameItems.UnitsStacks;

namespace TBS_Game.GameItems
{
    public class Player
    {
        bool IsTurn = false;
        //UnitsStack stack = new UnitsStack();
        ICommonStack[] stack = new ICommonStack[3];

        public Player()
        {
        }

    }



    /*
    public class UnitsStack
    {
        List<UnitsData> units = new List<UnitsData>();

        public UnitsStack()
        {
            
        }

    }
    public class UnitsData
    {
        public string UnitsType { get; set; }
        public int UnitsCount { get; set; }
        public int TotalHP { get; set; }
        public int UnitsDamage { get; set; }
        public int UnitsSpeed { get; set; }

        public UnitsData()
        {
            UnitsCount = Helpers.RandomizeMethods.GetRandomStackSize(); 
        }

        public UnitsData(string unitType)
        {
            UnitsType = unitType;
        }
    }

    public enum UType
    {
        Swordsman,
        Archer,
        Peasant
    }
    public struct Range
    {
        public int MinDamage;
        public int MaxDamage;
    }
    */

}
