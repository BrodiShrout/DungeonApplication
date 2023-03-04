using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibarayOfDoom
{
    public class Ashimagari : Monster
    {
        //Fields

        //Props
        public bool IsntHidden { get; set; }


        //Constructors/Ctors
        public Ashimagari(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, WeaponTypes weaponDrop, bool isntHidden)
            : base(name, maxLife, hitChance, block, maxDamage, minDamage, description, weaponDrop)
        {
            IsntHidden = isntHidden;

        }

        //Method
        public Ashimagari()
        {
            MaxLife = 23;
            MaxDamage = 8;
            Name = "Ashimagari (out)";
            Life = 23;
            HitChance = 18;
            Block = 10;
            MinDamage = 1;
            Description = "The Ashimagari is out in the open. You are able to seem them";
            WeaponDrop = WeaponTypes.Dagger;
            IsntHidden = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsntHidden ? "The Ashimagari lerks in the shadows and cannot be seen by the player" : " The Ashimari is out in the open and can be seen by the player");
        }

        public override int CalcBlock()
        {
            //return base.CalcBlock();
            int calculatedBlock = Block;
            if (IsntHidden)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
        }
    }
}
