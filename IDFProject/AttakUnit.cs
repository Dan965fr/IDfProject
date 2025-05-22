using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace IDFProject
{
    internal abstract class AttackUnit
    {
        //public abstract string NameType { get; }
        //public abstract List <string> Arsenal { get; }
        //public abstract int AmountOfFuel { get; }
        //public abstract List<string> Effectiveness { get; }
        
        public abstract void Attack();

    }
}
