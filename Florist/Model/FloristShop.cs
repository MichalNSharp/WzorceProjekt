using Florist.Interface;
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
        public FloristShop(IFlowerFactory flowerFactory)
        {
            PriceList priceList = PriceList.GetInstance();

            priceList.SetPrice(flowerFactory.CreateFlower(FlowerType.Rose,0), 20);
            priceList.SetPrice(flowerFactory.CreateFlower(FlowerType.Iris, 0), 15);
            priceList.SetPrice(flowerFactory.CreateFlower(FlowerType.Daisy, 0), 10);
        }
    }
}
