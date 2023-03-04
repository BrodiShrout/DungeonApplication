using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibarayOfDoom
{
    internal class Oni : Monster
    {
        //Fields

        //Props
        public bool IsCalm { get; set; }


        //Constructors/Ctors
        public Oni(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, WeaponTypes weaponDrop, bool isCalm)
            : base(name, maxLife, hitChance, block, maxDamage, minDamage, description, weaponDrop)
        {
            IsCalm = isCalm;
        }

        //Method
        public Oni()
        {
            MaxLife = 24;
            MaxDamage = 9;
            Name = "Calm Oni ";
            Life = 24;
            HitChance = 22;
            Block = 12;
            MinDamage = 1;
            Description = "The oni is not enraged but no docile either";
            WeaponDrop = WeaponTypes.Katana;
            IsCalm = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsCalm ? "A chaotic spirit that is currently sprinting towards you at full speed" : "A spirit that is currently running toward you at a normal pace");
        }

        public override int CalcBlock()
        {
            //return base.CalcBlock();
            int calculatedBlock = Block;
            if (IsCalm)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;

        }
    }
}
