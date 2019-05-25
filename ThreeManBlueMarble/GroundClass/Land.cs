using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeManBlueMarble
{
    class Land : Ground
    {
        private double price; // 토지별 토지 구매 가격을 저장
        private double toll; // 토지별 통행료를 저장
        private string username; // 토지별 유저의 이름을 저장
        private double landvalue; // 땅의 가치 토지가격 + 빌딩가격;







        // 프로퍼티
        public double Price { get { return price; } set { price = value; } }
        public double Toll { get { return toll; } set { toll = value; } }
        public string Username { get { return username; } set { username = value; } }
        public double Landvalue { get { return landvalue; } set { landvalue = value; } }
    }
}
