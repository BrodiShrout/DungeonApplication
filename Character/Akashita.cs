using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibarayOfDoom
{
    public class Akashita : Monster
    {
        //Fields

        //Props
        public bool IsOut { get; set; }


        //Method
        public Akashita()
        {
            MaxLife = 24;
            MaxDamage = 9;
            Name = "Uncovered Archer";
            Life = 24;
            HitChance = 10;
            Block = 11;
            MinDamage = 1;
            Description = "The Archer is out and staring at you.";
            WeaponDrop = WeaponTypes.Bow;
            IsOut = false;
        }

        //Constructors/Ctors
        public Akashita(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, WeaponTypes weaponDrop, bool isOut)
            : base(name, maxLife, hitChance, block, maxDamage, minDamage, description, weaponDrop)
        {
            IsOut = isOut;
        }
        public override string ToString()
        {
            return base.ToString() + (IsOut ? "You cannot see the archer. He has the high ground." : "You can see the archer as he draws his bow aiming at you.");
        }

        public override int CalcBlock()
        {
            //return base.CalcBlock();
            int calculatedBlock = Block;
            if (IsOut)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
        }

    }
}