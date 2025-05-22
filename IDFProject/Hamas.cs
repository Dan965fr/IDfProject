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
        
        
        public override List<string> Members { get; set; } 

        public override void AddMember(string member)
        {
            Members.Add(member);
        }
        public override void RemoveMember(string member)
        {
            Members.Remove(member);
        }



    }
    




    
}
