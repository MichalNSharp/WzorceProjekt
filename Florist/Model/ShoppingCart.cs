using Florist.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist.Model
{
    class ShoppingCart
    {
        private List<IFlower> flowers = new List<IFlower>();

        public void AddToCart(IFlower flower)
        {
            flowers.Add(flower);
        }

        public void RemoveFromCart(IFlower flower)
        {
            flowers.Remove(flower);
        }

        public List<IFlower> GetFlowers()
        {
            return flowers;
        }

        public override string ToString()
        {
            string result = null;
            foreach (var item in flowers)
            {
                result += item.ToString();
            }
            return result;
        }
    }
}
