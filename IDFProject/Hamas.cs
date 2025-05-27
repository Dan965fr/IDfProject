using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFProject
{
    internal class Hamas : Organization
    {
        public override string Name => "Hamas";
        public override string DateTimeFounded => "1987";



        public override string Leader { get; set; } = "Ismail Ania";
        
        
        public override List<Terrorist> Members { get; set; } 

        public Hamas()
        {
            Members = new List<Terrorist>();
        }

        public override void AddMember(Terrorist member)
        {
            Members.Add(member);
        }
        public override void RemoveMember(Terrorist member)
        {
            Members.Remove(member);
        }



    }
    




    
}
