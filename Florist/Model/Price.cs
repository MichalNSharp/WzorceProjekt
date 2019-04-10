using Florist.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist.Model
{
    class Price : IPrice
    {
        public Price(string flowerName, int flowerPrice)
        {
            this.FlowerName = flowerName;
            this.FlowerPrice = flowerPrice;
        }
        public string FlowerName;
        public int FlowerPrice;
    }
}
