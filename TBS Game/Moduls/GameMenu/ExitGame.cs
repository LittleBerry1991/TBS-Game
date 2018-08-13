using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Game.Moduls.GameMenu
{   

    /*
    // при сохранении/ загрузке из каждого стэка берем только два числа :  CurrentTotalHP и 
    public class UnitData : ICommonStack
    {
        protected int unitCount = Helpers.RandomizeMethods.GetRandomStackSize();
        protected List<Swordsman> SwrdStack = new List<Swordsman>();
        protected int CurrentTotalHP;


        bool IsStackDead = false;   //  закрыть ли для текущей игры текущий стек
        bool IsTurnStack = false;   //  порядок хода в границах одного игрока  между стэками отрядов


        public int minD
        {
            get
            { return 2; }
            set
            { minD = 2; }
        }
        public int maxD
        {
            get
            { return 3; }
            set
            { maxD = 3; }
        }

        // может это свойство нах. не нада?!   //  уже нада))))
        public int UnitsCount
        {
            get
            { return unitCount; }
            set
            {
                UnitsCount = unitCount;
                CurrentTotalHP = unitCount * this.SwrdStack[0].HitPoints;  // хотя хз решение
            }
        }

        public UnitData()
        {
            for (int i = 0; i < unitCount - 1; i++)
            {
                SwrdStack.Add(new Swordsman());
            }
        }
        public UnitData(int TotalHP, bool IfGameContinue)
        {
            //   бля , нада эти 25 как-то правильно вызвать
            //   наверное в классах Unit-ов  параметры сделаю статикой
            unitCount = (TotalHP % 25 > 0) ? TotalHP % 25 + 1 : TotalHP % 25;
            for (int i = 0; i < unitCount - 1; i++)
            {
                SwrdStack.Add(new Swordsman());
            }
        }


        //         конец блока инициализации

        public int GetRandomTotalDamage()
        {
            int minDmg, maxDmg;
            Random rnd = new Random();

            if (SwrdStack != null || SwrdStack.Count > 0)
            {
                minDmg = SwrdStack[0].DamagePoints.MinDamage * this.SwrdStack.Count;
                maxDmg = SwrdStack[0].DamagePoints.MaxDamage * this.SwrdStack.Count;

                return Helpers.RandomizeMethods.GetRandomDamage(minDmg, maxDmg);
            }
            else
                return 0;
        }

        // свойства minD и maxD сделаны только для этого
        public int GetRandomTotalDamage2()
        {
            return Helpers.RandomizeMethods.GetRandomDamage2(this, SwrdStack.Count);
        }

        public void SubtractionHP(int damage)
        {
            var tempCurrStackSize = this.SwrdStack.Count;
            var injuredUnit = 0;

            CurrentTotalHP = (CurrentTotalHP - damage) > 0 ? CurrentTotalHP - damage : 0;

            tempCurrStackSize = CurrentTotalHP / this.SwrdStack[0].HitPoints;
            injuredUnit = CurrentTotalHP % this.SwrdStack[0].HitPoints;

            tempCurrStackSize = (injuredUnit > 0) ? +1 : tempCurrStackSize;
            int DeadUnitsCount = this.SwrdStack.Count - tempCurrStackSize;
            this.SwrdStack.RemoveRange(this.SwrdStack.Count - 1 - DeadUnitsCount, DeadUnitsCount);
        }

        //  методы шо нада написать: 
        //  +(сделал) GetRandomTotalDamage   -  расчитать урон стэка
        //  AttackTo  - выбор кого атаковать    , хотя хз может его кинуть в class Player
        //  MissTurn - пропуск хода            -  тож к Player
        //  +(сделал) SubtractionHP  - притом что этот метод надо сделать умным , так чтобы если урон вычитался сразу с раненых солдат
        //  бля а как очередь ходов реализовать . ааааааааааа?

    }
*/
}
