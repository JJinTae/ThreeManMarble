using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeManBlueMarble
{
    class HighMan : OfficeMan
    {
        public double Salary()
        {
            this.Cash += this.Getmoney;
            return this.Getmoney;
        }
        public HighMan()
        {
            this.Getmoney = 15;
            this.Cash = 100;
        }
    }
}
