using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeManBlueMarble
{
    class LowMan : OfficeMan, IDiscountBuy
    {
        public double Salary()
        {
            this.Cash += Getmoney;
            return this.Getmoney;
        }
        public LowMan()
        {
            this.Cash = 100;
            this.Getmoney = 10;
        }
    }
}
