using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzorceProjekt.Interfaces.FactoryMethodsInterfaces;

namespace WzorceProjekt.Classes.FactoryMethods
{
    class MsgDisplayFactory
    {
        public static IMsgDisplay getInstance()
        {
            return new DialogDisplay();
        }
    }
}
