using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFProject
{    
    public class Terrorist
    {
        public string Name;
        public int Rank;
        public bool IsAlive;
        public List<string> Weapons;

        public Terrorist(string name, int rank, List<string> weapons)
        {
            Name = name;
            Rank = (rank >= 1 && rank <= 5) ? rank : 1;
            IsAlive = true;
            Weapons = weapons;
        }

         
        public static Terrorist CreateRandomTerrorist()
        {
            Random rnd = new Random();

            string[] names = { "Ahmed", "Khaled", "Mohammed",  "Hassan" };
            string[] allWeapons = { "knife", "gun", "m16", "ak47" };

            string name = names[rnd.Next(names.Length)];
            int rank = rnd.Next(1, 6);  

            int numWeapons = rnd.Next(1, 4); 
            List<string> weapons = new List<string>();

            while (weapons.Count < numWeapons)
            {
                string weapon = allWeapons[rnd.Next(allWeapons.Length)];
                if (!weapons.Contains(weapon))
                    weapons.Add(weapon);
            }

            return new Terrorist(name, rank, weapons);
        }

        public void ShowInfo()
        {
            Console.WriteLine("TERRORIST INFO");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Rank: " + Rank);
            Console.WriteLine("Status: " + (IsAlive ? "Alive" : "Dead"));
            Console.WriteLine("Weapons: " + string.Join(", ", Weapons));
            
        }
    }






}

    }
