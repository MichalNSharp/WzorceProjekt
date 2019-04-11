using Florist.Model.Flowers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist.Model
{
    class FloristShop
    {
        public FloristShop()
        {
            PriceList priceList = PriceList.GetInstance();

            priceList.SetPrice(new Rose(0), 20);
            priceList.SetPrice(new Iris(0), 15);
            priceList.SetPrice(new Tulip(0), 10);
        }
    }
}
