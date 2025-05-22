using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFProject
{
    internal class UAS:AttackUnit
    {
        private static int _counter = 1;
        public int Id { get; }
        public UAS()
        {
            Id = _counter++;
        }

        public string NameType => $"hermes450 #{Id}";
        public Dictionary<string, int> Arsenal => new Dictionary<string, int> { { "spike", 5 } };
        public int AmountOfFuel => 3;
        public List<string> Effectiveness => new List<string> { "cars", "person" };

        public override void Attack()
        {
            //AmountOfFuel -= 1;
        }
    }
}
