using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFProject
{
    internal class IDF
    {
        private string YearOfEstablishment;
        private string currentommander;
        protected Aman AmanUnit;
        protected AttackUnit AttakUnit;

        private IDF()
        {
            YearOfEstablishment = "21 05 1948";
            currentommander = "aviv cochavi";

            var units = new List<AttackUnit>
            {
                new Cannon(), new Cannon(), new Cannon(),
                new Plane(), new Plane(),
                new UAS(), new UAS(), new UAS(), new UAS()
            };
        }

    }
}
