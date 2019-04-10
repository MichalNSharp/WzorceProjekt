using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist.Model.Flowers
{
    class Daisy : Flower
    {
        public Daisy(int amount)
        {
            this.Name = "Daisy";
            this.Color = "White";
            this.SetFlowerPrice(35);
        }
    }
}
