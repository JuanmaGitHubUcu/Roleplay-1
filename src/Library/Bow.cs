using System;

namespace Roleplay
{
    public class Bow
    {
        private int attackValue;

        public int AttackValue
        {
            get
            {
                return this.attackValue;
            }
            set
            {
                if (value > 0)
                {
                    this.attackValue = value;
                }
                else
                {
                    this.attackValue = 0;
                }
            }
        }

        public int defenseValue;

        public int DefenseValue
        {
            get
            {
                return this.defenseValue;
            }
            set
            {
                if (value > 0)
                {
                    this.defenseValue = value;
                }
                else
                {
                    this.defenseValue = 0;
                }
            }
        }

        public Bow(int attack, int defense)
        {
            this.attackValue = attack;
            this.defenseValue = defense;
        }
    }
}