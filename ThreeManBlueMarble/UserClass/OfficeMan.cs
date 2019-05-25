using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeManBlueMarble
{
    class OfficeMan : User
    {
        public override void BuyLand(double price)
        {
            this.Cash -= price;
        }
    }
}
