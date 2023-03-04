using LibraryOfDoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibarayOfDoom
{
    public class Player : Character
    {
        //Fields

        //Probs
        public Race PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        //Constructors
        public Player(string name, int maxLife, int hitChance, int block, Race playerRace, Weapon equippedWeapon)
            : base(name, maxLife, hitChance, block)
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;
            switch (PlayerRace)
            {
                case Race.Orc:
                    HitChance += 15;
                    MaxLife += 5;
                    break;
                case Race.Dark_Elf:
                    HitChance += 15;
                    MaxLife += 5;
                    break;
                case Race.Khajit:
                    HitChance += 15;
                    MaxLife += 5;
                    break;
                case Race.Argonian:
                    HitChance += 16;
                    MaxLife += 6;
                    break;
                case Race.Dwarf:
                    HitChance += 3;
                    MaxLife += 2;
                    break;
                case Race.Goblin:
                    HitChance += 13;
                    MaxLife += 3;
                    break;
                case Race.Fairy:
                    HitChance += 14;
                    MaxLife += 7;
                    break;
                case Race.Dragonborn:
                    HitChance += 20;
                    MaxLife += 10;
                    break;
                case Race.Human:
                    HitChance += 1;
                    MaxLife += 2;
                    break;
                default:
                    break;
            }
        }
        //Methods
        public override string ToString()
        {
            //create a string , switch on player race and write some description about that race
            //string description = PlayerRace.ToString();
            return base.ToString() + $"\nWeapon: {EquippedWeapon}\n";
        }
        public override int CalcDamage()
        {
            //create a random object
            Random rand = new Random();
            //determine the damage
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage);
            //return the damage
            return damage;
        }
        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }
        public static Player GetRace(Race PlayerRace)
        {
            Player Orc = new("Orc", 30, 40, 40, Race.Orc, Weapon.GetWeapon(WeaponTypes.Knife));
            Player Dark_Elf = new("Dark Elf", 30, 40, 40, Race.Dark_Elf, Weapon.GetWeapon(WeaponTypes.Knife));
            Player Khajit = new("Khajit", 30, 40, 40, Race.Khajit, Weapon.GetWeapon(WeaponTypes.Knife));
            Player Argonian = new("Argonian", 30, 40, 40, Race.Argonian, Weapon.GetWeapon(WeaponTypes.Knife));
            Player Dwarf = new("Dwarf", 30, 40, 40, Race.Dwarf, Weapon.GetWeapon(WeaponTypes.Knife));
            Player Goblin = new("Goblin", 30, 40, 40, Race.Goblin, Weapon.GetWeapon(WeaponTypes.Knife));
            Player Fairy = new("Fairy", 30, 40, 40, Race.Fairy, Weapon.GetWeapon(WeaponTypes.Knife));
            Player Dragonborn = new("Dragonborn", 30, 40, 40, Race.Dragonborn, Weapon.GetWeapon(WeaponTypes.Knife));
            Player Human = new("Human", 30, 40, 40, Race.Human, Weapon.GetWeapon(WeaponTypes.Knife));
            List<Player> player = new()
        {
            Orc,
            Dark_Elf,
            Khajit,
            Argonian,
            Dwarf,
            Goblin,
            Fairy,
            Dragonborn,
            Human
        };
            return Player.GetRace(PlayerRace);
        }
    }
}