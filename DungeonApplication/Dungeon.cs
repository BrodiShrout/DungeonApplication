using System.Media;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using LibarayOfDoom;
using LibraryOfDoom;

namespace DungeonApplication_fin_
{
    internal class Dungeon
    {
        static void Main(string[] args)
        {
            if (OperatingSystem.IsWindows())
            {
                SoundPlayer wolf = new SoundPlayer("wolfHowl.wav");
                wolf.Load();
                wolf.Play();
            }
            #region Title/Introduction
            Console.Title = "=-=-=-=-Welcome to the Forest =-=-=-=";
            Console.WriteLine("     _                  _\r\n    | '-.            .-' |\r\n    | -. '..\\\\,.//,.' .- |\r\n    |   \\  \\\\\\||///  /   |\r\n   /|    )M\\/%%%%/\\/(  . |\\\r\n  (/\\  MM\\/%/\\||/%\\\\/MM  /\\)\r\n  (//M   \\%\\\\\\%%//%//   M\\\\)\r\n(// M________ /\\ ________M \\\\)\r\n (// M\\ \\(',)|  |(',)/ /M \\\\) \\\\\\\\  \r\n  (\\\\ M\\.  /,\\\\//,\\  ./M //)\r\n    / MMmm( \\\\||// )mmMM \\  \\\\\r\n     // MMM\\\\\\||///MMM \\\\ \\\\\r\n      \\//''\\)/||\\(/''\\\\/ \\\\\r\n      mrf\\\\( \\oo/ )\\\\\\/\\\r\n           \\'-..-'\\/\\\\\r\n              \\\\/ \\\\ \n Hello Travaler.....Welcome to the Forest");
            #endregion
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
            #region Player Creation
            //Variable to keep score
            int score = 0;

            // Weapon creation
            //Potential Expantion - Displays a list of weapons and let them pick
            // Play object creation
            //Potential Expantion - let them enter their own name and show them the races and let them pick one
            string playerName = " ";
            Race playerRace = new Race();
            string raceChoice;

            #region Character
            Console.WriteLine("What is your name traveler?\n");
            playerName = Console.ReadLine();

            Console.WriteLine($"\nWelcome to the Forest {playerName}\n");
            #region Character input/Menu
            bool validRace = false;
            do
            {
                Console.WriteLine("I grant you the choice to choose who you shall be...... However, I must advice you to think carefully.....\n" +
                        "(please enter the number you wish below)\n" +
                        "\t1.) Orc,\n" +
                        "\t2.) Dark_Elf,\n" +
                        "\t3.) Khajit,\n" +
                        "\t4.) Argonian,\n" +
                        "\t5.) Dwarf,\n" +
                        "\t6.) Goblin,\n" +
                        "\t7.) Fairy,\n" +
                        "\t8.) Dragonborn,\n" +
                        "\t9.) Human,\n");
                raceChoice = Console.ReadLine();
                Console.Clear();
                switch (raceChoice)
                {
                    case "1":
                        playerRace = Race.Orc;
                        validRace = true;
                        Console.WriteLine($"You chose  {playerRace}\n");
                        ConsoleKey user = Console.ReadKey(true).Key;
                        if (true)
                        {
                            Console.WriteLine($"You are a {playerRace}");
                        }
                        break;
                    case "2":
                        playerRace = Race.Dark_Elf;
                        validRace = true;
                        Console.WriteLine($"You chose  {playerRace}\n");
                        ConsoleKey user2 = Console.ReadKey(true).Key;
                        if (true)
                        {
                            Console.WriteLine($"You are a {playerRace}");
                        }
                        break;
                    case "3":
                        playerRace = Race.Khajit;
                        validRace = true;
                        Console.WriteLine($"You chose  {playerRace}\n");
                        ConsoleKey user3 = Console.ReadKey(true).Key;
                        if (true)
                        {
                            Console.WriteLine($"You are a {playerRace}");
                        }
                        break;
                    case "4":
                        playerRace = Race.Argonian;
                        validRace = true;
                        Console.WriteLine($"You chose  {playerRace}\n");
                        ConsoleKey user4 = Console.ReadKey(true).Key;
                        if (true)
                        {
                            Console.WriteLine($"You are a {playerRace}");
                        }
                        break;
                    case "5":
                        playerRace = Race.Dwarf;
                        validRace = true;
                        Console.WriteLine($"You chose  {playerRace}\n");
                        ConsoleKey user5 = Console.ReadKey(true).Key;
                        if (true)
                        {
                            Console.WriteLine($"You are a {playerRace}");
                        }
                        break;
                    case "6":
                        playerRace = Race.Goblin;
                        validRace = true;
                        Console.WriteLine($"You chose  {playerRace}\n");
                        ConsoleKey user6 = Console.ReadKey(true).Key;
                        if (true)
                        {
                            Console.WriteLine($"You are a {playerRace}");
                        }
                        break;
                    case "7":
                        playerRace = Race.Fairy;
                        validRace = true;
                        Console.WriteLine($"You chose  {playerRace}\n");
                        ConsoleKey user7 = Console.ReadKey(true).Key;
                        if (true)
                        {
                            Console.WriteLine($"You are a {playerRace}");
                        }
                        break;
                    case "8":
                        playerRace = Race.Dragonborn;
                        validRace = true;
                        Console.WriteLine($"You chose  {playerRace}\n");
                        ConsoleKey user8 = Console.ReadKey(true).Key;
                        if (true)
                        {
                            Console.WriteLine($"You are a {playerRace}");
                        }
                        break;
                    case "9":
                        playerRace = Race.Human;
                        validRace = true;
                        Console.WriteLine($"You chose  {playerRace}\n");
                        ConsoleKey user9 = Console.ReadKey(true).Key;
                        if (true)
                        {
                            Console.WriteLine($"You are a {playerRace}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again");
                        break;
                }
            } while (!validRace);
            Weapon Knife = new Weapon(4, 2, " Knife", 5, false, WeaponTypes.Knife);
            Player player = new Player(playerName, 40, 40, 40, playerRace, Knife);

            #endregion


            #endregion



            #endregion

            #region Main Game Loop
            bool exit = false;
            do
            {
                //TODID Generate a random room
                Console.WriteLine(GetRoom());

                //TODID Select a random monster to inhabit the room
                Monster monster = Monster.GetMonster();
                Console.WriteLine($"As you look into the room you see {monster.Name}, who dwells in the corrnor ");

                #region Gamplay menu loop
                bool reloadRoom = false;
                do
                {
                    //TODID Gameplay menu
                    Console.Write("\nPlease choose an action:\n" +
                       "A) Attack\n" +
                       "R) Run away\n" +
                       "P) Player Info\n" +
                       "M) Monster Info\n" +
                       "X) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            //Combat
                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {
                                //combat rewards -> money, health, weapon
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"You killed {monster.Name}! They dropped {monster.WeaponDrop}.\n\n" +
                                    $"Would you like to trade your {Knife} for the {monster.WeaponDrop}? Y/N:");
                                ConsoleKey weaponInput = Console.ReadKey(true).Key;
                                if (weaponInput == ConsoleKey.Y)
                                {
                                    WeaponTypes weapons = monster.WeaponDrop;
                                }
                                    Console.WriteLine($"You took the {monster.Name}'s {monster.WeaponDrop}");

                                Console.ResetColor();
                                //max life again
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                if (player.Life > player.MaxLife)
                                {
                                    player.Life = player.MaxLife;
                                }
                                Console.ResetColor();
                                //flip the inner-loop bool to true to get another monster
                                reloadRoom = true;
                                score++;
                            }

                            Console.WriteLine("GET THEM!!!!!!!!!!!!!!!!");
                            break;

                        case ConsoleKey.R:
                            // Attack of opportunity
                            Console.WriteLine($"{monster.Name} attacks while you try to flee");
                            Combat.DoAttack(monster, player);
                            Console.WriteLine();//formatting
                            reloadRoom = true;
                            break;

                        case ConsoleKey.P:
                            Console.WriteLine("Player info: ");
                            Console.WriteLine(player);
                            break;

                        case ConsoleKey.M:
                            Console.WriteLine("Monster info: ");
                            Console.WriteLine(monster);
                            break;

                        case ConsoleKey.X:
                        case ConsoleKey.E:
                        case ConsoleKey.Escape:
                            Console.WriteLine("No one likes a quitter...");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid input, please try again");
                            break;
                    }


                    //Check player life -> if loop
                    if (player.Life <= 0)
                    {
                        Console.WriteLine($"You died to {monster.Name}..... Better luck next time....");
                        exit = true;
                    }

                } while (reloadRoom != true && exit != true);
            } while (exit != true);
            #endregion
            //show the score
            Console.WriteLine("You defeated " + score + " Monsters " +
          (score == 1 ? "." : "s."));

            #endregion
        }//end main
        private static string GetRoom()
        {
            string[] rooms =
            {
                 "The room is dark and musty with the smell of wondering souls.",
                "You enter a sparkely room and instantly get glitter all over you.",
                "You peer through the open doorway into a broad, pillared hall. The columns of stone are \n" +
                "carved as tree trunks and seem placed at random like trees in a forest. Stone root systems crawl " +
                "out into the floor and marble branches expand across the ceiling.",
                "A stone throne stands in the center of this cold chamber. The throne shows the same criss-crossed \n" +
                "patteren that is displayed on the door of the room",
                 "You inhale a salty yet stale smell of stagnet salt water, as you peer into the room you see a pool of \n" +
                 "moss ridden water in the center of the room. you ponder what this room was used for before you see him...",
                 "This seemingly never ending hallway leads to a dead end, causing you to turn around and walking \n" +
                 "back to the room you had just come from. When yu enter the room you notice it has hanged from \n" +
                 "a prestine throne room to a room covered in over-grown ivy vines and a moss covered floor. ",
                 "You hear as water drips overhead as you enter a cold circular room with damp walls. You notice \n" +
                 "a crack in the wall thats allowing sunlight to trickle in.",
                 "All sound seems to fade away as you enter an ancient room with worn walls. An inch of water covers\n" +
                 " the polishedfloor. Moss that lines the wall seems to be glowing, giving off a mysterious light. It seems like \n" +
                 "this room is an entertaining hall.",
                 "You are can hear stomping coming from the room ahead. When you peer in you see nothing but the \n" +
                 "damp walls and the water covered floors, as you walk in the door you came from slams shut."
            };

            Random rand = new Random();

            int index = rand.Next(rooms.Length);

            string room = rooms[index];
            //possible refacttor

            return room;
            //return room[new Random().Next(rooms.Length)];
        }//end GetRoom
    }
}