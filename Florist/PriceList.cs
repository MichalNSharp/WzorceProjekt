using Florist.Interface;
using Florist.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist
{
    class PriceList
    {
        private static PriceList priceList;
        private List<IPrice> prices = new List<IPrice>();

        public static PriceList GetInstance()
        {
            if (priceList == null)
            {
                priceList = new PriceList();
            }
            return priceList;
        }

        public void SetPrice(string flowerColor, int flowerPrice)
        {
            prices.Add(new Price(flowerColor,flowerPrice));
        }
    }
}
