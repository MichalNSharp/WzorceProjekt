using Florist.Model;
using Florist.Model.Flowers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist
{
    class Program
    {
        static void Main(string[] args)
        {
            FloristShop floristShop = new FloristShop();

            Customer Janek = new Customer("Janek", 100);

            Janek.GetFlower(new Rose(5));
            Janek.GetFlower(new Daisy(1));

            ShoppingCart shoppingCart = Janek.GetShoppingCart();

            Console.WriteLine("Wózek Janka:\n" + shoppingCart);
            Janek.Pay();
            Console.WriteLine("Wózek Janka:\n" + shoppingCart);
        }
    }
}
