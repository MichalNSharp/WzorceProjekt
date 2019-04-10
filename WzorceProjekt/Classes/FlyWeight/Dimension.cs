using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjekt.Classes.FlyWeight
{
    sealed class Dimension
    {
        private int width;
        private int height;

        public Dimension(int w, int h)
        {
            width = w;
            height = h;
        }

        public int getWidth() { return width; }
        public int getHeight() { return height; }

        public override string ToString()
        {
            return width + "x" + height;
        }
    }
}
