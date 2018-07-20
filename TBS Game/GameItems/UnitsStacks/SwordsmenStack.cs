using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBS_Game.GameItems.Units;

namespace TBS_Game.GameItems.UnitsStacks
{
    // при сохранении/ загрузке из каждого стэка берем только два числа :  CurrentTotalHP и 
    public class SwordsmenStack : ICommonStack
    {
        protected int unitCount = (IsStartNewGame)? Helpers.RandomizeMethods.GetRandomStackSize(): 0;
        protected List<Swordsman> SwrdStack = new List<Swordsman>();
        protected int CurrentTotalHP;
        
        bool IsStackDead = false;   //  закрыть ли для текущей игры текущий стек
        bool IsTurnStack = false;   //  порядок хода в границах одного игрока  между стэками отрядов
        static bool  IsStartNewGame = false;        //   нада поркинуть её в player или game

        public int UnitsCount
        {
            get
            { return unitCount; }
            set
            {
                UnitsCount = unitCount;
                CurrentTotalHP = unitCount * Swordsman.HitPoints;  // вот так вот
            }
        }

        public SwordsmenStack()
        {
            for (int i = 0; i < unitCount - 1; i++)
            {
                SwrdStack.Add(new Swordsman());
            }
        }
        public SwordsmenStack(int TotalHP, bool IfGameContinue)
        {
            unitCount = (TotalHP % Swordsman.HitPoints > 0) ? TotalHP % Swordsman.HitPoints + 1 : TotalHP % Swordsman.HitPoints;   
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
                minDmg = Swordsman.MinDamage * this.SwrdStack.Count;
                maxDmg = Swordsman.MaxDamage * this.SwrdStack.Count;

                return Helpers.RandomizeMethods.GetRandomDamage(minDmg, maxDmg);
            }
            else
                return 0;
        }

        public int GetRandomTotalDamage2()
        {
            return Helpers.RandomizeMethods.GetRandomDamage2(SwrdStack[0] , SwrdStack.Count);
        }

        public void SubtractionHP(int damage)
        {
            var tempCurrStackSize = this.SwrdStack.Count;
            var injuredUnit = 0;

            CurrentTotalHP = (CurrentTotalHP - damage) > 0 ? CurrentTotalHP - damage : 0;

            tempCurrStackSize = CurrentTotalHP / Swordsman.HitPoints;
            injuredUnit = CurrentTotalHP % Swordsman.HitPoints;

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
}
