using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClassesInheritance
{
    public abstract class Monster
    {   
        public enum MonsterActions{ Attack, Defend, Retreat}


        private int _id;
        private string _name;
        private int _age;
        private bool _isActive;
        private string _nickname;           
        private int _casualties;
        private bool _likesHumans;

        public bool LikesHumans
        {
            get { return _likesHumans; }
            set { _likesHumans = value; }
        }


        public int Casualties
        {
            get { return _casualties; }
            set { _casualties = value; }
        }


        public string Nickname
        {
            get { return _nickname; }
            set { _nickname = value; }
        }


        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }


        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public Monster()
        {

        }

        public Monster(int ID, string name)
        {

            _id = ID;
            _name = Name;

        }

        public virtual string Greeting()
        {

            return $"Hello my name is {Name}.";

        }

        public abstract string UseNickname();
        
        

        public abstract bool IsHappy();
        
    }
}
