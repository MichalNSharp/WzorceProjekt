using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist.Interface
{
    interface IFlower
    {
        string GetFlowerName();
        int GetFlowerAmount();
        void SetFlowerAmount(int amount);
    }
}
