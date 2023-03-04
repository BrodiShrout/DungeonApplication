using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfDoom
{
    public abstract class Character
    { 
        //Fields
        private string _name;
        private int _maxLife;
        private int _life;
        private int _hitChance;
        private int _block;

        //Props
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        public int Life
        {
            get { return _life; }
            set { _life = value; }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }

        //Constructors/Ctors
        public Character() { }

        protected Character(string name, int maxLife, int hitChance, int block)
        {
            Name = name;
            MaxLife = maxLife;
            Life = maxLife;
            HitChance = hitChance;
            Block = block;
            Name = name;
            MaxLife = maxLife;
            Life = maxLife;
            HitChance = hitChance;
            Block = block;
        }

        //Method
        public override string ToString()
        {
            //return base.ToString(); 
            return $"\n----------{Name}----------\n\n" +
                $"Life: {Life} ot {MaxLife}\n" +
                $"Hitchance: {HitChance}\n" +
                $"Block: {Block}\n";
        }
        //CalcBlock() returns an int -> return Block;
        public virtual int CalcBlock()
        {
            return _block;
        }
        //CalcHitChance() returns an int -> return HitChance;
        public virtual int CalcHitChance()
        {
            return HitChance;
        }
        //CalcDamage() returns an int -> return 0;
        public abstract int CalcDamage();
    }
}