using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeManBlueMarble
{
    class Building : Land
    {
        public Building(double price, double toll, string nameground, int numground)
        {
            this.Price = price;
            this.Toll = toll;
            this.NameGround = nameground;
            this.NumGround = numground;
            this.Username = null;
        }
    }
}