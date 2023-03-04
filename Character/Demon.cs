using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibarayOfDoom
{
    public class Demon : Monster
    {
        //Fields

        //Props
        public bool IsDocile { get; set; }


        //Constructors/Ctors
        public Demon(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, WeaponTypes weaponDrop, bool isDocile)
            : base(name, maxLife, hitChance, block, maxDamage, minDamage, description, weaponDrop)
        {
            IsDocile = isDocile;
        }

        //Method
        public Demon()
        {
            MaxLife = 23;
            MaxDamage = 6;
            Name = "Docile Demon ";
            Life = 23;
            HitChance = 16;
            Block = 9;
            MinDamage = 1;
            Description = "The demon hasn't been threated but the player...... yet";
            WeaponDrop = WeaponTypes.Great_Sword;
            IsDocile = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsDocile ? "An enraged and dangerous demon" : "A docile and seemingly harmless demon");
        }

        public override int CalcBlock()
        {
            //return base.CalcBlock();
            int calculatedBlock = Block;
            if (IsDocile)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
        }
    }
}