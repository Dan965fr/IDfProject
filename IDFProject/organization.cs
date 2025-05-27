using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFProject
{
    abstract class Organization
    {
        public abstract string Name { get; }
        public abstract string DateTimeFounded {  get;  }
        public abstract string Leader { get; set; }
        public abstract List<Terrorist> Members { get; set; }



        public abstract void AddMember(Terrorist member);
        public abstract void RemoveMember(Terrorist member);
    }
}
