
using Florist2.FlowerClasses.Flowers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist2.FlowerClasses
{
    class FlowerFactory : IFlowerFactory
    {
        public IFlower CreateFlower(FlowerType flowerType, int Amount)
        {
            switch (flowerType)
            {
                case FlowerType.Rose:
                    return new Rose(Amount);
                case FlowerType.Daisy:
                    return new Daisy(Amount);
                case FlowerType.Iris:
                    return new Iris(Amount);
                case FlowerType.Tulip:
                    return new Tulip(Amount);
                default:
                    throw new ArgumentOutOfRangeException();
            }
                
        }
    }
}
