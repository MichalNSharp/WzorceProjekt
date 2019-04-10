using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist.Model.Flowers
{
    class Rose : Flower
    {
        public Rose(int amount )
        {
            this.Name = "Rose";
            this.Color = "Red";
            this.SetFlowerPrice(amount);
        }
    }
}
