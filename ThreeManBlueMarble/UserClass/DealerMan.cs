using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeManBlueMarble
{
    class DealerMan : User, ICommonBuy
    {
        public override void BuyLand(double price)
        {
            this.Cash -= price*0.8;//땅을 20퍼센트 할인된 값에 매입
        }
        public DealerMan()
        {
            this.Cash = 100;
        }

        public double Salary()
        {
            this.Getmoney = rand.Next(0, 16);
            //수입 랜던값
            this.Cash += this.Getmoney;
            return this.Getmoney;
        }
    }
}