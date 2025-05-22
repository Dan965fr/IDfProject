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
        public abstract List<string> Members { get; set; }



        public abstract void AddMember(string member);
        public abstract void RemoveMember(string member);
    }
}
