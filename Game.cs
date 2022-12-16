﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Projekt_skit_med_personer
{
    internal class gameboy
    {
        //This is the "inventory" system
        static int inventory(int wep_phys, int wep_magic, int defence_point)
        {
            //variable and so we can use randome
            Random rd = new Random();
            int wep_dmg_phys = 0;
            int wep_dmg_magic = 0;
            int def = 0;

            //arreys for weapon and armure changes the type and the stat
            int[][] physicalweapon =
            {
                new int[] { 1, 2, 3 },
                new int[] { 2, 4, 6 },
                new int[] { 4, 8, 12 },
            };

            int[][] magicalweapon =
            {
                new int[] { 1, 2, 3 },
                new int[] { 2, 4, 6 },
                new int[] { 4, 8, 12 },
            };

            int[][] defence =
            {
                new int[] { 0, 1, 2 },
                new int[] { 2, 3, 4 },
                new int[] { 4, 5, 6 },
            };

            // if-loops so we chan pick the item 1 for weak 2 for medium 3 for strong
            if (wep_phys == 1)
            {
                wep_dmg_phys = physicalweapon[0][rd.Next(physicalweapon.Length)];
            }else if (wep_phys == 2)
            {
                wep_dmg_phys = physicalweapon[1][rd.Next(physicalweapon.Length)];
            }else if (wep_phys == 3)
            {
                wep_dmg_phys = physicalweapon[2][rd.Next(physicalweapon.Length)];
            };

            if (wep_magic == 1)
            {
                wep_dmg_magic = magicalweapon[0][rd.Next(magicalweapon.Length)];
            }else if (wep_magic == 2)
            {
                wep_dmg_magic = magicalweapon[1][rd.Next(magicalweapon.Length)];
            }else if (wep_magic == 3)
            {
                wep_dmg_magic = magicalweapon[2][rd.Next(magicalweapon.Length)];
            };

            if (defence_point == 1)
            {
                def = defence[0][rd.Next(defence.Length)];
            }else if (defence_point == 2)
            {
                def = defence[1][rd.Next(defence.Length)];
            }else if (defence_point == 3)
            {
                def = defence[2][rd.Next(defence.Length)];
            }

            return wep_dmg_phys;
            return wep_dmg_magic;
            return def;

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Thank you " + name + " Do you want to enter the dungeon! Y/N");
            string enter = Console.ReadLine();
            if (enter == "Y" || enter == "y")
            {
                floor1p1();
            };

            static void floor1p1()
            {
                Console.WriteLine("You enter the spiral abyss in search of riches beyond human imagination. \nBut unbeknown to you is that pain and suffering are the only things the abyss has to offer.");
                Console.WriteLine("After wandering aimlessly you are attacked by monsters. \nWell what did you expect, it is the abyss after all, you’re bound to encounter enemies along your path.");
                monster("skeleton", "phys_wep", 1, 0);
                Console.WriteLine("You continue on through the corridors…");
                Console.WriteLine("You see a light ahead, it is a camp of monsters.");
                monster("zombie", "phys_wep", 2, 0);
                Console.WriteLine("After defeating the monsters you hear some voices, you decide to follow them but not reveal yourself. \nEventually they find the staircase down and you follow after you are sure they won’t be close to the staircase…");
                floor1p2();
            }

            static void floor1p2()
            {
                Console.WriteLine("When you get down you make sure to head away from voices, it is best to avoid people when possible, so you were told at least.");
                Console.WriteLine("The bland walls of the abyss melt into each other you may have walked in many circles, been in the same places over and over. ");
                Console.WriteLine("You start thinking it would be best to trail the people you followed in the beginning. \nBeing lost in thought you are caught by surprise!");
                monster("zombie", "phys_wep", 2, 0);
                Console.WriteLine("The after defeating the monsters you continue forward…");
                Console.WriteLine("After what feels like a few hours you find the staircase to the next floor…");
                floor1p3();
            }
            static void floor1p3()
            {
                Console.WriteLine("You decide to rest by the staircase but out of view, \nit will be easier to follow someone who knows their way around the floors. ");
                Console.WriteLine("You awake hearing voices, surprised you were able to fall asleep in this unsettling place. \nStaying silent you peek toward the staircase out of the place were you were hiding. ");
                Console.WriteLine("A group of what seems like merchants are at the foot of the staircase, you overhear their conversation…");
                Console.WriteLine("It seems they are heading towards the deepest part of the 2nd floor, where Zetsubou lies.");
                Console.WriteLine("Following the group you keep your distance as best you can, \nthe fleeting glances of the group tell you there are 3 merchants which have hired a group of 2 mercenaries to help protect them from the numerous threats on the way to Zetsubou. \nThey seem to have worked together before, they have visible chemistry and understand each other well. ");
                Console.WriteLine("From behind you hear the sounds of monsters gathering so you decide to ambush them before they push you into the people in front or are too many to handle…");
                monster("zombie", "phys_wep", 2, 0);
                Console.WriteLine("Since nobody came back you assume the sounds of battle had not reached them…");
                Console.WriteLine("Pushing on you notice it is eerily quiet, there are no sounds ahead of you. \nCould the other group have gotten that far ahead? You decide to pick up the pace.");
                Console.WriteLine("You come to the staircase, but in the adjacent corridor you see a group of monsters. \nYou decide to fight the monsters, for fun if not any other reason…");
                floor2p1();
            }

            static void floor2p1()
            {
                Console.WriteLine("Entering the 2nd floor you start to feel nauseous, the feeling disappears briefly, you are glad the feeling doesn’t persist. ");
                Console.WriteLine("The second floor looks very much like the first. Bland and boring gray polished walls, painted red in several places, blood. ");
                Console.WriteLine("You realize the group is nowhere to be seen, you didn’t take too long fighting the monsters… \nYou remember the journal saying something about time going faster on the lower floors. \nYou don’t know how strong the effect is, but since you don’t hear anything you assume they have at least a several minute head start. ");
                Console.WriteLine("You decide to head out. ");
                monster("zombie", "phys_wep", 2, 0);
                monster("zombie", "phys_wep", 2, 0);
                Console.WriteLine("You don't see a way through. You decide to turn back. ");
            }

            /*
             * Monster is a meathod to fight monsters.
             * It's like rock, paper scissors but instead it's light attack, heavy attack and defend.
             */
            static void monster(string monster, string wep_type, int wep_num, int armor_val)
            {
                //monster syntax hp, atk, def
                //define variables
                int[] skeleton = { 5, 3, 0};
                int[] zombie = { 10, 2, 1};
                int monster_stat_hp = 1;
                int monster_stat_atk = 0;
                int monster_stat_def = 0;
                int player_hp = 100;
                int player_atk = 0;
                int player_def = armor_val;
                string wep_type_dmg = null;
                string monster_type = null;
                int damage_dealt = 0;

                //Defines difrent variables depending on what monster you are fighting.
                if (wep_type == "phys_wep")
                {
                    wep_type_dmg = "phys";
                    player_atk = inventory(wep_num, 0, 0);
                }

                if (wep_type == "magic_wep")
                {
                    wep_type_dmg = "magic";
                    player_atk = inventory(0, wep_num, 0);
                }

                if (monster == "skeleton")
                {
                    monster_stat_hp = skeleton[0];
                    monster_stat_atk = skeleton[1];
                    monster_stat_def = skeleton[2];
                    monster_type = "phys";
                }
                if (monster == "zombie")
                {
                    monster_stat_hp = zombie[0];
                    monster_stat_atk = zombie[1];
                    monster_stat_def = zombie[2];
                    monster_type = "phys";
                }

                //A while loop to keep the fight going.
                while (monster_stat_hp >= 0)
                {
                    //To stop it when you die.
                    if (player_hp <= 0)
                    {
                        Environment.Exit(0);
                    }
                    Console.WriteLine("You are fighting a " + monster + "! It has " + monster_stat_hp + "hp left and " + monster_stat_atk + "atk and " + monster_stat_def + "def!");
                    /*
                     * Here the fight begins!
                     * The player writes 1, 2 or 3 depending on what to use.
                     */
                    Console.WriteLine("Heavy attack beats defend and defend beats light attack and light attack beats heavy attack!");
                    Console.WriteLine("You have "+player_hp+"hp left!");
                    Console.WriteLine("Do you want to dodge, attack or defend:   light attack: 1     heavy attack: 2     defend: 3");
                    string choise = Console.ReadLine();
                    Console.Clear();
                    Random rand = new Random();
                    int monster_choise = rand.Next(4);
                    if (choise == "1")
                    {
                        if (monster_choise == 2)
                        {
                            if (wep_type_dmg == monster_type)
                            {
                                damage_dealt = player_atk - monster_stat_def;
                                if (damage_dealt < 0)
                                {
                                    damage_dealt = 0;
                                }
                                monster_stat_hp -= damage_dealt;
                            }
                            Console.WriteLine("You used light attack and the "+ monster+ " used heavy attack, you dealt: "+ damage_dealt+ "Damage! It has " +monster_stat_hp+ "hp left!");
                        }
                        else if (monster_choise == 3)
                        {
                            damage_dealt = (monster_stat_atk - player_def);
                            if (damage_dealt < 0)
                            {
                                damage_dealt = 0;
                            }
                            player_hp -= damage_dealt;
                            Console.WriteLine("You used light attack and the "+ monster+ " used defend, you took "+ damage_dealt+ "Damage! You have "+ player_hp+ "hp left!");
                        }
                        else
                        {
                            Console.WriteLine("You both light attack and deal 0dmg");
                        }
                    }
                    if (choise == "2")
                    {
                        if (monster_choise == 3)
                        {
                            if (wep_type_dmg == monster_type)
                            {
                                damage_dealt = player_atk - monster_stat_def;
                                if (damage_dealt < 0)
                                {
                                    damage_dealt = 0;
                                }
                                monster_stat_hp -= damage_dealt;
                            }
                            Console.WriteLine("You used heavy attack and the "+ monster+ " used defend, you dealt: "+ damage_dealt+ "Damage! It has "+ monster_stat_hp+ "hp left!");
                        }
                        else if (monster_choise == 1)
                        {
                            damage_dealt = (monster_stat_atk - player_def);
                            if (damage_dealt < 0)
                            {
                                damage_dealt = 0;
                            }
                            player_hp -= damage_dealt;
                            Console.WriteLine("You used heavy attack and the "+ monster+ " used light attack, you took "+ damage_dealt+ "Damage! You have "+ player_hp+ "hp left!");
                        }
                        else
                        {
                            Console.WriteLine("You both heavy attck and deal 0dmg");
                        }
                    }
                    if (choise == "3")
                    {
                        if (monster_choise == 1)
                        {
                            if (wep_type_dmg == monster_type)
                            {
                                damage_dealt = player_atk - monster_stat_def;
                                if (damage_dealt < 0)
                                {
                                    damage_dealt = 0;
                                }
                                monster_stat_hp -= damage_dealt;
                            }
                            Console.WriteLine("You used defend and the "+ monster+ " used light attck, you dealt: "+ damage_dealt+ "Damage! It has "+ monster_stat_hp+ "hp left!");
                        }
                        else if (monster_choise == 2)
                        {
                            damage_dealt = (monster_stat_atk - player_def);
                            if (damage_dealt < 0)
                            {
                                damage_dealt = 0;
                            }
                            player_hp -= damage_dealt;
                            Console.WriteLine("You used defend and the "+ monster+ " used heavy attack, you took "+ damage_dealt+ "Damage! You have "+ player_hp+ "hp left!");
                        }
                        else
                        {
                            Console.WriteLine("You both defend and deal 0dmg");
                        }
                    }
                }
                Console.WriteLine("You claim victory over the " + monster + "!");
                return;
            }
        }
    }
}
