using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibarayOfDoom
{
    public class Kitsuna : Monster
    {
        //Fields

        //Props
        public bool IsWondering { get; set; }

        
        //Constructors/Ctors
        public Kitsuna(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, WeaponTypes weaponDrop, bool isWondering)
            : base(name, maxLife, hitChance, block, maxDamage, minDamage, description, weaponDrop)
        {
            IsWondering = isWondering;
        }

        //MethodR
        public Kitsuna()
        {
            MaxLife = 25;
            MaxDamage = 11;
            Name = "Wondering Kitsuna ";
            Life = 25;
            HitChance = 25;
            Block = 13;
            MinDamage = 1;
            Description = "A wondering Kitsuna just looking to fight";
            WeaponDrop = WeaponTypes.Kunai;
            IsWondering = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsWondering ? "A Kitsuna that has gone out of its way to fight you" : "A Kitsuna that has stumbled upon you and has decided to pick a foght");
        }

        public override int CalcBlock()
        {
            //return base.CalcBlock();
            int calculatedBlock = Block;
            if (IsWondering)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
        }
    }
}