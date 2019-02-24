using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClassesInheritance
{
    public class SeaMonster : Monster, IBattle
    {
        private bool _hasGills;
        private string _seaName;

        public string SeaName
        {
            get { return _seaName; }
            set { _seaName = value; }
        }



        public bool HasGills
        {
            get { return _hasGills; }
            set { _hasGills = value; }
        }


        public override bool IsHappy()
        {
            return true;
        }

        public override string UseNickname()
        {
            return $"All my Friends call me {Nickname}";
        }

        public MonsterActions MonsterBattleResponses()
        {
            Random randomNumber = new Random();
            int actionProbability = randomNumber.Next(0, 101);


            if (actionProbability >= 66)
            {
                return MonsterActions.Retreat;
            }
            else if (actionProbability <= 33)
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
