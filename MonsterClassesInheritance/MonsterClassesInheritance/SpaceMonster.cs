using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClassesInheritance
{
    public class SpaceMonster : Monster, IBattle
    {
        private bool _hasSpaceShip;

        public bool HasSpaceShip
        {
            get { return _hasSpaceShip; }
            set { _hasSpaceShip = value; }
        }

        public override string Greeting()
        {
            return $"Hello, I am a Space Monster and my name is {Name}";
        }

        public override bool IsHappy()
        {
            //if (_hasSpaceShip)
            //{
            //    return true;
            //}

            //else
            //{
            //    return false;
            //}
            return _hasSpaceShip ? true : false;
        }

        public override string UseNickname()
        {
            return $"All my Friends call me {Nickname}";
        }
        

        public MonsterActions MonsterBattleResponses()
        {
            Random randomNumber = new Random();
            int actionProbability = randomNumber.Next(0, 101);
            

            if (actionProbability>=70)
            {
                return MonsterActions.Retreat;
            }
            else if (actionProbability <=33)
            {
                return MonsterActions.Attack;
            }
            else
            {
                return MonsterActions.Defend;
            }


        }
    }
}
