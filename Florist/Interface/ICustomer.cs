using Florist.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist.Interface
{
    interface ICustomer
    {
        ShoppingCart GetShoppingCart();
        void GetFlower(IFlower flower);

        void Pay();
        int GetCash();
        string GetCustomerName();
        void Pack(IBox box);
    }
}
