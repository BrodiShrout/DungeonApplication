using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibarayOfDoom
{
    public class Gorgon : Monster
    {
        //Fields

        //Props
        public bool IsScaly { get; set; }


        //Constructors/Ctors
        public Gorgon(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, WeaponTypes weaponDrop, bool isScaly)
            : base(name, maxLife, hitChance, block, maxDamage, minDamage, description, weaponDrop)
        {
            IsScaly = isScaly;
        }

        //Method
        public Gorgon()
        {
            MaxLife = 15;
            MaxDamage = 2;
            Name = "Baby Gorgon ";
            Life = 12;
            HitChance = 7;
            Block = 3;
            MinDamage = 1;
            Description = "A small gorgon, but stay alert its still dangerous";
            WeaponDrop = WeaponTypes.Madusas_Head;
            IsScaly = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsScaly ? "A full grown gorgon with long snakes as hair" : "A baby gorgon with little baby snakes as hair");
        }

        public override int CalcBlock()
        {
            //return base.CalcBlock();
            int calculatedBlock = Block;
            if (IsScaly)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
        }

    }
}
