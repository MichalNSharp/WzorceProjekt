
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist2.FlowerClasses
{
    interface IFlowerFactory
    {
        IFlower CreateFlower(FlowerType flowerType, int Amount);
    }
}
