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
            int wepdmg = 0;

            int[][] physicalweapon =
                {
                    new int[] { 1, 2, 3 },
                    new int[] { 2, 4, 6 },
                    new int[] { 3, 8, 12 },
                };

            if (wepp == 0)
            {
                wepdmg = physicalweapon[0][rd.Next(physicalweapon.Length)];
            }
            else if (wepp == 1)
            {
                wepdmg = physicalweapon[1][rd.Next(physicalweapon.Length)];
            }
            else if (wepp == 2)
            {
                wepdmg = physicalweapon[2][rd.Next(physicalweapon.Length)];
            };

            return wepdmg;

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
