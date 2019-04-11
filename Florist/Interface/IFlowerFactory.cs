using Florist.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist.Interface
{
    interface IFlowerFactory
    {
        IFlower CreateFlower(FlowerType flowerType, int Amount);
    }
}
