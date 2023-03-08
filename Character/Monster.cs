using LibraryOfDoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibarayOfDoom
{
    public class Monster : Character
    {
        //Fields
        private int _minDamage;

        //Props
        public int MaxDamage { get; set; }
        public string Description { get; set; } = null!;
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }
        public WeaponTypes WeaponDrop { get; set; }

        //Constructors/Ctors
        public Monster() { }
        public Monster(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, WeaponTypes weaponDrop)
            : base(name, maxLife, hitChance, block)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
            WeaponDrop = weaponDrop;
        }

        //Method
        public override string ToString()
        {
            return base.ToString() + $"\n Damage: {MinDamage} to {MaxDamage}\n Description: {Description}\n";
        }
        public override int CalcDamage()
        {
            return new Random().Next(MaxDamage, MinDamage + 1);
        }
        public static Monster GetMonster()
        {
            // Create a variety of monsters
            Gorgon m1 = new("Medusa", hitChance: 15, block: 6, maxLife: 30, maxDamage: 5, minDamage: 1, description: "A green slithering mess of hair who was thought to have been slain by Perseus, back from the dead.", isScaly: false, weaponDrop: WeaponTypes.Madusas_Head);
            NoviceVampire m2 = new("Darth-Pire", hitChance: 20, block: 12, maxLife: 35, maxDamage: 10, minDamage: 3, description: "A chaotic novice vampire who wields a duel red lightsaber..", newVamp: false, weaponDrop: WeaponTypes.DuelBlade_Lightsaber);
            AncientVampire m3 = new("Darth-Dracula", hitChance: 23, block: 14, maxLife: 40, maxDamage: 14, minDamage: 6, description: "As the leader of the vampires everyone listens and bows to him. Hes an ancient vampire.", novVamp: false, weaponDrop: WeaponTypes.Darth_Blade);
            NewBornVampire m4 = new("Luke Vamwalker", hitChance: 30, block: 13, maxLife: 45, maxDamage: 12, minDamage: 5, description: "The son of Darth-Dracula. He holds no real power even though he things he does. He is a newborn vampire (recent turn)", changeling: false, weaponDrop: WeaponTypes.Blaster);
            Demon m5 = new("Dark Knight", hitChance: 33, block: 18, maxLife: 46, maxDamage: 16, minDamage: 7, description: "A knight that lerks in the shadows. He is clad in pitch black armor, you can see his red eyes shining through the thin slits in his helmet", isDocile: false, weaponDrop: WeaponTypes.Great_Sword);
            Ashimagari m6 = new("Dark Assasin", hitChance: 36, block: 20, maxLife: 47, maxDamage: 17, minDamage: 8, description: "An assasin that is the embodiment of the shadows themselves. I pity the man that meets him.", isntHidden: false, weaponDrop: WeaponTypes.Dagger);
            Akashita m7 = new("The Great Archer", hitChance: 40, block: 22, maxLife: 48, maxDamage: 18, minDamage: 9, description: "An archer of the dead. He was known as the best marksmen in all of Europe before he succumb to a supernatural attack.", isOut: false, weaponDrop: WeaponTypes.Bow);
            Oni m8 = new("Hatamoto Samuri", hitChance: 45, block: 24, maxLife: 49, maxDamage: 19, minDamage: 10, description: "A high ranking samuri who now romes the earth as a verngful spirit who is ready to fight anyone and everyone he comes across.", isCalm: false, weaponDrop: WeaponTypes.Katana);
            Kitsuna m9 = new("The Great Kitsuna Spirit", hitChance: 40, block: 26, maxLife: 50, maxDamage: 20, minDamage: 11, description: "The Great Kistuna is a sly and fast spirit. Good luck catching her.", isWondering: false, weaponDrop: WeaponTypes.Kunai);

            //Add the monsters to a collection
            Gorgon babyGorgon = new();
            NoviceVampire newVamp = new();
            AncientVampire novVamp = new();
            NewBornVampire changeling = new();
            Demon isDocile = new();
            Ashimagari isntHidden = new();
            Akashita isOut = new();
            Oni isCalm = new();
            Kitsuna isWondering = new();

            List<Monster> monsters = new()
            {
                m1,
                babyGorgon,
                m2,
                newVamp,
                m3,
                novVamp,
                m4,
                changeling,
                m5,
                isDocile,
                m6,
                isntHidden,
                m7,
                isOut,
                m8,
                isCalm,
                m9,
                isWondering,
            };
            return monsters[new Random().Next(monsters.Count)];
        }
    }
}