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
        //private string FlowerName;
        private int FlowerPrice;

        private IFlower _flower;

        public Price(IFlower flower, int flowerPrice)
        {
            this._flower = flower;
            this.FlowerPrice = flowerPrice;
        }


        public string GetFlowerName()
        {
            return _flower.GetFlowerName();
        }

        public int GetFlowerPrice()
        {
            return FlowerPrice;
        }
    }
}
