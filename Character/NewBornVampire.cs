using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibarayOfDoom
{
    public class NewBornVampire : Monster
    {

        public DateTime TimeCreated { get; set; }

        public NewBornVampire(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, WeaponTypes weaponDrop, DateTime timeCreated)
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
        public bool Changeling { get; set; }

        //Constructors/Ctors
        public NewBornVampire(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, WeaponTypes weaponDrop, bool changeling)
            : base(name, maxLife, hitChance, block, maxDamage, minDamage, description, weaponDrop)
        {
            Changeling = changeling;
        }

        //Method
        public NewBornVampire()
        {
            MaxLife = 16;
            MaxDamage = 4;
            Name = "Changeling ";
            Life = 16;
            HitChance = 9;
            Block = 5;
            MinDamage = 1;
            Description = "A creature that is not yet a vampire but is no longer human.";
            WeaponDrop = WeaponTypes.Blaster;
            Changeling = false;
        }
        public override int CalcBlock()
        {
            //return base.CalcBlock();
            int calculatedBlock = Block;
            if (Changeling)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
        }
    }
}