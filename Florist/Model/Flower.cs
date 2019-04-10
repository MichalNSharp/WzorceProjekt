using Florist.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist.Model
{
    class Flower : IFlower
    {
        public string Name { get; set; }
        public string Color { get; set; }
        private int _Amount;

        public int GetFlowerPrice()
        {
            return _Amount;
        }
        
        public void SetFlowerPrice(int amount)
        {
            _Amount = amount;
        }

        public override string ToString()
        {
            return Name + " " + Color + " Amount: " + _Amount + " \n";
        }
    }
}
