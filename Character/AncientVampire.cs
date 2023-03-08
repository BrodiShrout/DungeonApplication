using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibarayOfDoom
{
    public class AncientVampire : Monster
    {

        public DateTime TimeCreated { get; set; }

        public AncientVampire(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, WeaponTypes weaponDrop)
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
        public bool NovVamp { get; set; }
        //Constructors/Ctors
        public AncientVampire(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, WeaponTypes weaponDrop, bool novVamp)
            : base(name, maxLife, hitChance, block, maxDamage, minDamage, description, weaponDrop)
        {
            NovVamp = novVamp;


        }

        //Method
        public AncientVampire()
        {
            MaxLife = 18;
            MaxDamage = 7;
            Name = "Novice Vampire";
            Life = 18;
            HitChance = 11;
            Block = 7;
            MinDamage = 1;
            Description = "A vampire that is still getting  used to its powers and new way of life.";
            WeaponDrop = WeaponTypes.Darth_Blade;
            NovVamp = false;
        }
        public override int CalcBlock()
        {
            //return base.CalcBlock();
            int calculatedBlock = Block;
            if (NovVamp)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
        }
    }
}