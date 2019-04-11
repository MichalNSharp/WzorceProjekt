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
        public string FlowerName;
        public int FlowerPrice;

        public Price(string flowerName, int flowerPrice)
        {
            this.FlowerName = flowerName;
            this.FlowerPrice = flowerPrice;
        }


        public string GetFlowerName()
        {
            return FlowerName;
        }

        public int GetFlowerPrice()
        {
            return FlowerPrice;
        }
    }
}
