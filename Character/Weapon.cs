using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibarayOfDoom
{
    public class Weapon
    {
        //Fields
        private int _maxDamage;
        private int _minDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private WeaponTypes _weapons;


        //Props
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }
        public WeaponTypes Weapons
        {
            get { return _weapons; }
            set { _weapons = value; }
        }

        //Constructors/Ctors
        public Weapon() { }

        public Weapon(int maxDamage, int minDamage, string name, int bonusHitChance, bool isTwoHanded, WeaponTypes weapons)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Weapons = weapons;
        }

        //Method
        public override string ToString()
        {
            //return base.ToString(); 
            return $"\n----------{Name}----------\n\n" +
                $"Weapon Type: {Weapons}\n" +
                $"Max Damage: {MaxDamage}\n" +
                $"Min Damage: {MinDamage}\n" +
                $"Bonus Hit Chance: {BonusHitChance}\n" +
                $"Is Two Handed?: {IsTwoHanded}\n";
        }
        public static Weapon GetWeapon(WeaponTypes Weapons)
        {
            Weapon w1 = new(4, 2, "Knife", 5, false, WeaponTypes.Knife);
            Weapon w2 = new(7, 2, "Medusa's Head", 10, false, WeaponTypes.Madusas_Head);
            Weapon w3 = new(9, 2, "Dule Red Lightsaber", 20, true, WeaponTypes.DuelBlade_Lightsaber);
            Weapon w4 = new(9, 2, "Darth Blade", 15, true, WeaponTypes.Darth_Blade);
            Weapon w5 = new(15, 2, "Blaster", 5, true, WeaponTypes.Blaster);
            Weapon w6 = new(11, 2, "Great Sword", 12, true, WeaponTypes.Great_Sword);
            Weapon w7 = new(17, 2, "Dagger", 7, false, WeaponTypes.Dagger);
            Weapon w8 = new(20, 2, "Katana", 10, false, WeaponTypes.Katana);
            Weapon w9 = new(22, 2, "Kunai", 25, false, WeaponTypes.Kunai);

            List<Weapon> equippedWeapon = new()
            {
                w1,
                w2,
                w3,
                w4,
                w5,
                w6,
                w7,
                w8,
                w9
            };
            return Weapon.GetWeapon(Weapons);
        }
    }
}