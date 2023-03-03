﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bootcamp
{
    public static class MiniDC
    {
        public static void StartDC()
        {
            Console.WriteLine("Welcome to The Red Stone Temple!");
            Console.WriteLine("What is your player's name? ");
            string pName = Console.ReadLine();
            Player player = new Player(0, pName, 50);

            //Create some monsters...
            Player[] monster = new Player[5];
            monster[1] = new Player(1, "Steven", 20);
            monster[2] = new Player(2, "Araconos", 7);
            monster[3] = new Player(3, "Greggor the Giant", 100);
            monster[4] = new Player(4, "Frida the Fearless", 42);

            //Dealing with the world...
            int maxX = 11;
            int maxY = 11;
            Location[,] location = new Location[maxX, maxY];
            location[5, 5] = new Location("Home", "You see a glowing red stone that looks confortable to sit upon", 0);
            location[4, 4] = new Location("Treasure Room", "You see golden goblets and silver daggers. You hear a deep rumbling groan.", 3);
            location[6, 6] = new Location("Dungeon", "You find a deserted, moss filled dungeon. It seems to be undiscovered", 1);

            //Set the player location...
            int pX = 5;
            int pY = 5;

            //Create a die
            Random dice = new Random();

            //Game begins...
            while(true)
            {
                //Display the location & player health...
                Console.WriteLine("\n------------------------------------");
                Console.WriteLine("\tYour health: {0}", player.Health);
                Console.WriteLine("\tYour Location: ({0},{1}", pX, pY);

                //Tell player details about where they are...
                if(location[pX,pY] != null)
                {
                    Console.WriteLine("\t *** {0} ***", location[pX, pY].LocationName);
                    Console.WriteLine("\t ### {0} ###", location[pX, pY].Description);

                    //Monster Detection
                    if (location[pX, pY].MonsterID != 0)
                    {
                        int mID = location[pX, pY].MonsterID;
                        Console.WriteLine("\t !! You encounter {0} with health {1} !!", monster[mID].Name, monster[mID].Health);

                        //Battle Begins Here!
                        int damageToMonster = dice.Next(1, 20); //Roll a d20
                        int damageToPlayer = dice.Next(1, 20);

                        //Deduct from health...
                        player.Health -= damageToPlayer;
                        monster[mID].Health -= damageToMonster;

                        //Speak the results...
                        Console.WriteLine("\t\t !!! You take {0} damage!", damageToPlayer);
                        Console.WriteLine("\t\t !!! {0) takes {1} damage!", monster[mID].Name, damageToMonster);
                        Console.WriteLine("\t\t !!! Your Health: {0}.   Their Health: {1}", player.Health, monster[mID].Health);

                        //Deal with death...
                        if (monster[mID].Health <= 0)
                        {
                            Console.WriteLine("\t\t\t !!! You KILL {0} !!!", monster[mID].Name);
                            location[pX, pY].MonsterID = 0; //Removes monster from room
                            location[pX, pY] = null; //Optional...
                        }
                        if( player.Health <= 0)
                        {
                            Console.WriteLine("I'm sorry to inform you that you have died. Insert 25 cents to try again.");
                            return;
                        }


                    }
                    
                }

                //Add a special healing room....
                if(pX == 8 &&  pY ==8)
                {
                    Console.WriteLine("You start feeling better!!!");
                    player.Health += dice.Next(1, 6);
                }

                //Ask for user commands...
                Console.Write("Your wish is my command > ");
                string cmd = Console.ReadLine().ToLower().Trim();
                if(cmd == "q" || cmd == "quit")
                {
                    Console.WriteLine("Thanks for playing. Insert 25 cents to play again!");
                    return;
                }

                //Movement...
                if (cmd == "n") pY--;
                if (cmd == "s") pY++;
                if (cmd == "e") pX++;
                if (cmd == "w") pX--;

                //Solve the OFF World problem...
                pX = Math.Clamp(pX, 0, maxX - 1);
                pY = Math.Clamp(pY, 0, maxY - 1);

                if (cmd == "m") Location.DrawMap(location, pX, pY);

                if (cmd == "save") SaveLoadData.SavePlayerData(player);

                try 
                {
                    if (cmd == "load") player = SaveLoadData.LoadPlayerData(player);
                }
                catch
                {
                    Console.WriteLine("Could not restore player data!");
                }
                

            }



        }


    }
}
