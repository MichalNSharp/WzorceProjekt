using Florist.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist.Model
{
    class Bag : IBox
    {
        private string BagOwner;
        private List<IFlower> flowerList;

        public Bag(ICustomer customer)
        {
            BagOwner = customer.GetCustomerName();
            flowerList = new List<IFlower>();
        }

        public void AddFlowerToBox(IFlower flower)
        {
            flowerList.Add(flower);
        }

        public List<IFlower> GetFlowerList()
        {
            return flowerList;
        }

        public string ShowDetails()
        {
            string result = "Torba foliowa " + BagOwner + " zawiera:\n";
            foreach (var item in flowerList)
            {
                result += item.ToString();
            }
            return result;
        }
    }
}
