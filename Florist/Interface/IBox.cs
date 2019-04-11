using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist.Interface
{
    interface IBox
    {
        List<IFlower> GetFlowerList();
        void AddFlowerToBox(IFlower flower);

        
    }
}
