﻿using System;
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
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Thank you "+name+" Do you want to enter the dungeon! Y/N");
            string enter = Console.ReadLine();
            if (enter == "Y" || enter == "y")
            {
                room1p1();
            };



        }
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
            if (monster == "skeleton")
            {
                int monster_stat_hp = skeleton[0];
                int monster_stat_atk = skeleton[1];
                int monster_stat_def = skeleton[2];
                Console.WriteLine("You are fighting a "+monster+"it has "+monster_stat_hp+"hp and "+monster_stat_atk+"atk and "+monster_stat_def+"def!");
            }
            //monster syntax hp, atk, def
            
           
        }
        
    }
}
