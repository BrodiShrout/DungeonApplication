using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibarayOfDoom
{
    internal class NoviceVampire : Monster
    {

        public DateTime TimeCreated { get; set; }


        public NoviceVampire(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, WeaponTypes weaponDrop, DateTime timeCreated)
            : base(name, hitChance, block, maxLife, maxDamage, minDamage, description, weaponDrop)
        {
            TimeCreated = DateTime.Now;

            //At night, our Vampire becomes significantly more dangerous
            if (TimeCreated.Hour < 6 || TimeCreated.Hour > 18)
            {
                HitChance += 10;
                Block += 10;
                MinDamage += 1;
                MaxDamage += 2;
            }
            TimeCreated = timeCreated;

        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}",
                base.ToString(),
                TimeCreated.Hour < 6 || TimeCreated.Hour > 18 ?
                "Empowered by the night" : "Weakened by the daylight");
        }
        //Fields

        //Props
        public bool NewVamp { get; set; }

        //Constructors/Ctors
        public NoviceVampire(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, WeaponTypes weaponDrop, bool newVamp)
            : base(name, maxLife, hitChance, block, maxDamage, minDamage, description, weaponDrop)
        {
            NewVamp = newVamp;
        }

        //Method
        public NoviceVampire()
        {
            MaxLife = 17;
            MaxDamage = 6;
            Name = "Newborn Vampire";
            Life = 17;
            HitChance = 10;
            Block = 6;
            MinDamage = 1;
            Description = "A newly changed vampire.";
            WeaponDrop = WeaponTypes.DuelBlade_Lightsaber;
            NewVamp = false;
        }
        public override int CalcBlock()
        {
            //return base.CalcBlock();
            int calculatedBlock = Block;
            if (NewVamp)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
        }

    }
}
