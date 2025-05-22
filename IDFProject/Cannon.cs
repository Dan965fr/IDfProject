using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFProject
{
    internal class Cannon : AttackUnit
    {
        private static int _counter = 1;
        public int Id { get; }
        public Cannon()
        {
            Id = _counter++;
        }

        public string NameType => $"M109 #{Id}";
        public Dictionary<string, int> Arsenal => new Dictionary<string, int> { {"bomb1", 3 } ,{"bomb2",2 } };
        public int AmountOfFuel => 40;
        public List<string> Effectiveness => new List<string> { "open spaces",};

        public override void Attack()
        {
           // AmountOfFuel -= 1;
        }
    }
}
