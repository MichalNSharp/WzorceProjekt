
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist2.FlowerClasses
{
    class Flower : IFlower
    {
        private string Name { get; set; }
        private string Color { get; set; }
        private int _Amount;

        public Flower(string name, string color, int amount)
        {
            this.Name = name;
            this.Color = color;
            this._Amount = amount;
        }

        public string GetFlowerName()
        {
            return Name;
        }

        public string GetFlowerColor()
        {
            return Color;
        }

        public int GetFlowerAmount()
        {
            return _Amount;
        }

        public void SetFlowerAmount(int amount)
        {
            this._Amount = amount;
        }

        public override string ToString()
        {
            return Name + " " + Color + " Amount: " + _Amount + " \n";
        }
    }
}
