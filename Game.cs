using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Projekt_skit_med_personer
{
    internal class game
    {
        static int inventory(int wepp, int wepm, int defp)
        {

            Random rd = new Random();
            int wepdmgp = 0;
            int wepdmgm = 0;
            int def = 0;

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

            if (wepp == 1)
            {
                wepdmgp = physicalweapon[0][rd.Next(physicalweapon.Length)];
            }else if (wepp == 2)
            {
                wepdmgp = physicalweapon[1][rd.Next(physicalweapon.Length)];
            }else if (wepp == 3)
            {
                wepdmgp = physicalweapon[2][rd.Next(physicalweapon.Length)];
            };

            if (wepm == 1)
            {
                wepdmgm = magicalweapon[0][rd.Next(magicalweapon.Length)];
            }else if (wepm == 2)
            {
                wepdmgm = magicalweapon[1][rd.Next(magicalweapon.Length)];
            }else if (wepm == 3)
            {
                wepdmgm = magicalweapon[2][rd.Next(magicalweapon.Length)];
            };

            if (defp == 1)
            {
                def = defence[0][rd.Next(defence.Length)];
            }else if (defp == 2)
            {
                def = defence[1][rd.Next(defence.Length)];
            }else if (defp == 3)
            {
                def = defence[2][rd.Next(defence.Length)];
            }

            return wepdmgp;
            return wepdmgm;
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
                room1p1();
            };

            static void room1p1()
            {
                Console.WriteLine("You enter the first room of the dungeon! You see a skeleton!");
                monster("skeleton", "phys_wep", 1, 0);
                
            }

            static void room1p2()
            {

            }

            static void monster(string monster, string wep_type, int wep_num, int armor_val)
            {
                //monster syntax hp, atk, def
                int[] skeleton = { 10, 4, 1};
                int[] zombie = { 20, 2, 4};
                int monster_stat_hp = 0;
                int monster_stat_atk = 0;
                int monster_stat_def = 0;
                int player_hp = 100;
                int player_atk = 0;
                int player_def = armor_val;
                string wep_type_dmg = null;
                string monster_type = null;
                int damage_dealt = 0;

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

                while (monster_stat_hp >= 0)
                {
                    Console.WriteLine("You are fighting a " + monster + "! It has " + monster_stat_hp + "hp left and " + monster_stat_atk + "atk and " + monster_stat_def + "def!");
                    Console.WriteLine("Heavy attack beats defend and defend beats light attack and light attack beats heavy attack!");
                    Console.WriteLine("Do you want to dodge, attack or defend: light attack: 1     heavy attack: 2     defend: 3");
                    string choise = Console.ReadLine();
                    Random rand = new Random();
                    int monster_choise = rand.Next(4);
                    if (choise == "1")
                    {
                        if (monster_choise == 2)
                        {
                            if (wep_type_dmg == monster_type)
                            {
                                damage_dealt = player_atk - monster_stat_def;
                                monster_stat_hp -= damage_dealt;
                            }
                            Console.WriteLine("You used light attack and the ", monster, " used heavy attack, you dealt: ", damage_dealt, "Damage! It has ", monster_stat_hp, "hp left!");
                        }
                        else if (monster_choise == 3)
                        {
                            damage_dealt -= (monster_stat_atk - player_def);
                            player_hp -= damage_dealt;
                            Console.WriteLine("You used light attack and the ", monster, " used defend, you took ", damage_dealt, "Damage! You have ", player_hp, "hp left!");
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
                                monster_stat_hp -= damage_dealt;
                            }
                            Console.WriteLine("You used heavy attack and the ", monster, " used defend, you dealt: ", damage_dealt, "Damage! It has ", monster_stat_hp, "hp left!");
                        }
                        else if (monster_choise == 1)
                        {
                            damage_dealt -= (monster_stat_atk - player_def);
                            player_hp -= damage_dealt;
                            Console.WriteLine("You used heavy attack and the ", monster, " used light attack, you took ", damage_dealt, "Damage! You have ", player_hp, "hp left!");
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
                                monster_stat_hp -= damage_dealt;
                            }
                            Console.WriteLine("You used defend and the ", monster, " used light attck, you dealt: ", damage_dealt, "Damage! It has ", monster_stat_hp, "hp left!");
                        }
                        else if (monster_choise == 2)
                        {
                            damage_dealt -= (monster_stat_atk - player_def);
                            player_hp -= damage_dealt;
                            Console.WriteLine("You used defend and the ", monster, " used heavy attack, you took ", damage_dealt, "Damage! You have ", player_hp, "hp left!");
                        }
                        else
                        {
                            Console.WriteLine("You both defend and deal 0dmg");
                        }
                    }
                }
            }
        }
    }
}
