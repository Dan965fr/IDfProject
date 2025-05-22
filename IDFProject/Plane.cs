using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFProject
{
    internal class Plane:AttackUnit
    {
        private static int _counter = 1;
        public int Id { get; }
        public Plane()
        {
            Id = _counter++;
        }

        public string NameType => $"f16 #{Id}";
        public Dictionary<string, int> Arsenal => new Dictionary<string, int> { { "1 ton bomb", 1 }, { "0.5 ton bomb", 3 } };
        public int AmountOfFuel => 8;
        public List<string> Effectiveness => new List<string> { "bildings" };

        public override void Attack()
        {
           // AmountOfFuel -= 1;
        }
    }
}
