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

            priceList.SetPrice("Rose", 20);
            priceList.SetPrice("Iris", 15);
            priceList.SetPrice("Tulip", 10);
        }
    }
}
