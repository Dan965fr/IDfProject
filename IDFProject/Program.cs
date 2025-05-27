using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFProject
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Terrorist terrorist = Terrorist.CreateRandomTerrorist();

            terrorist.ShowInfo();
            Console.ReadLine(); 

        }
    }
}
