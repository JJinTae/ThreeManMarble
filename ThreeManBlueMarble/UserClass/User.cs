using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeManBlueMarble
{
    abstract class User
    {
        
        private double cash; // User의 현금
        private double totalcash; // User의 토지 + 현금 재산 (통행료가 현금보다 부족할 시 사용)
        private string username; // User를 구분하기 위한 변수
        private double getmoney; // User의 월급 변수
        private int dicenum; // User별 주사위 숫자 변수
        private int position;
        

        public static Random rand = new Random();

        // User의 통행료 지불 메서드
        public double PayToll(double toll)
        {
                this.cash -= toll;
                return toll;
        }

        // User의 건물 판매 메서드
        public void SellLand(double landvalue)
        {
            this.cash += landvalue;
            this.totalcash -= landvalue;
        }

        // User의 통행료 수금 메서드
        public void GetToll(double toll)
        {
            this.cash += toll;
        }

        
        public abstract void BuyLand(double price); // 토지를 구매하는 추상메서드 OfficeMan : 기본가격 구매 / DealerMan : 20%할인된 금액


        public double Cash { get { return cash; } set { cash = value; } }
        public double Totalcash { get { return totalcash; } set { totalcash = value; } }
        public double Getmoney { get { return getmoney; } set { getmoney = value; } }
        public string Username { get { return username; } set { username = value; } }
        public int Dicenum { get { return dicenum; } set { dicenum = value; } }
        public int Position { get { return position; } set { position = value; } }
        
    }
}
