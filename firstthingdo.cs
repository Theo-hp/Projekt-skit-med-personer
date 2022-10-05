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
        static void Main(string[] args)
        {
            Console.WriteLine("Input Here:");
            string name = Console.ReadLine();
            Console.WriteLine("Thank you ", name, "Do you want to enter the dungeon! Y/N");
            string enter = Console.ReadLine();
            if (enter == "Y" || enter == "y")
            {
                room1p1();
            };



        }
        static void room1p1()
        {
            Console.WriteLine("You enter the first room of the dungeon! You see a skeleton!");
            fight1();

        }

        static void room1p2()
        {

        }

        public static void fight1()
        {
            monster mS = new monster();
            mS.HP = 10;
            mS.atk = 4;
            mS.name = "Skeleton";
            Console.WriteLine("You are fighting a", mS.name);

            room1p2();
            


        }

        public class monster
        {
            public int HP;
            public int atk;
            public string name;
        }
    }
}
