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
            string ans = Console.ReadLine();
            Console.WriteLine("Thank you ", ans);

            room1();



        }
        static void room1()
        {
            Console.WriteLine("You enter the first room of the dungeon! You see a skeleton!");
        }
        static void fight1()
        {
            monster mS = new monster();
            mS.HP = 10;
            mS.atk = 4;
            mS.name = "Skeleton";
            Console.WriteLine("You are fighting a", mS.name);
            Console.WriteLine("What do you want to use:  type: 1=fist  2=knife");
            string weapon = Console.ReadLine();
            if (weapon.ToLower() = "knife")
            {

            };


        }

        public class monster
        {
            public int HP;
            public int atk;
            public string name;
        }
    }
}
