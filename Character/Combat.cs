using LibarayOfDoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfDoom
{
    public class Combat
    {
        //NOT a datatype class so it will NOT have frields/props/ctors
        //It will simply serve as a "warehouse" for a variety of combat-related methods.
        public static void DoAttack(Character attacker, Character defender)
        {
            //get a random number from 1 - 100, determins hit
            int roll = new Random().Next(1, 101);
            Thread.Sleep(200); //pauses for 200 mili-seconds
            //The attacker hits if the roll is less than or equal to the attackers hit chance - defenders block
            if (roll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //calc the damage,
                int damageDealt = attacker.CalcDamage();

                //assign that damage to the defenders life
                defender.Life -= damageDealt;

                //output our results
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();

                //Maybe add health to hero after each fight

            }
            else//the attacker missed
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }
        }//end DoAttack
        public static void DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);
            //if the monster survives then they can attack
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }
        }
    }
}