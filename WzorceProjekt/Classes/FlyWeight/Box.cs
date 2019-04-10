using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjekt.Classes.FlyWeight
{
    class Box
    {
        private Dimension dim;
        private String cont;

        public Box(Dimension d, String c)
        {
            dim = d;
            cont = c;
        }

        public override string ToString()
        {
            return "Pudełko: " + dim + " Zawartość: " + cont;
        }
    }
}
