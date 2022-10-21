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
        static int inventory(int wepp, int wepm, int defp, int defm)
        {

            Random rd = new Random();
            int wepdmgp = 0;
            int wepdmgm = 0;
            int notdiep = 0;
            int notdiem = 0;

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

            int[][] physicaldefence =
            {
                new int[] { 0, 1, 2 },
                new int[] { 2, 3, 4 },
                new int[] { 4, 5, 6 },
            };

            int[][] magicaldefence =
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
                notdiep = physicaldefence[0][rd.Next(physicaldefence.Length)];
            }else if (defp == 2)
            {
                notdiep = physicaldefence[1][rd.Next(physicaldefence.Length)];
            }else if (defp == 3)
            {
                notdiep = physicaldefence[2][rd.Next(physicaldefence.Length)];
            }

            if (defm == 1)
            {
                notdiem = magicaldefence[0][rd.Next(magicaldefence.Length)];
            }else if (defm == 2)
            {
                notdiem = magicaldefence[1][rd.Next(magicaldefence.Length)];
            }else if (defm == 3)
            {
                notdiem = (magicaldefence[2][rd.Next(magicaldefence.Length)];
            }

            return wepdmgp;
            return wepdmgm;
            return notdiep;
            return notdiem;

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
                monster("skeleton");
                
            }

            static void room1p2()
            {

            }

            static void monster(string monster)
            {
                int[] skeleton = { 10, 4, 1 };
                int[] zombie = { 20, 2, 4 };
                int monster_stat_hp = 0;
                int monster_stat_atk = 0;
                int monster_stat_def = 0;
                int player_atk = inventory.;

                if (monster == "skeleton")
                {
                    monster_stat_hp = skeleton[0];
                    monster_stat_atk = skeleton[1];
                    monster_stat_def = skeleton[2];
                }
                Console.WriteLine("You are fighting a " + monster + "! It has " + monster_stat_hp + "hp and " + monster_stat_atk + "atk and " + monster_stat_def + "def!");
                monster_stat_hp = monster_stat_hp - player_atk;
                Console.WriteLine("You attack first and deal " + player_atk + " Damage! The "+monster+" has "+monster_stat_hp+"HP left!");

                //monster syntax hp, atk, def


            }

        }
    }
}
