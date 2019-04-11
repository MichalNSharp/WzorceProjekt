using Florist.Interface;
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

            ICustomer Janek = new Customer("Janek", 70);

            Janek.GetFlower(new Rose(2));
            Janek.GetFlower(new Iris(2));
            Janek.GetFlower(new Daisy(1));

            ShoppingCart shoppingCart = Janek.GetShoppingCart();

            Console.WriteLine("Wózek Janka:\n" + shoppingCart);
            Janek.Pay();
            Console.WriteLine("Wózek Janka po zapłaceniu:\n" + shoppingCart);
            Console.WriteLine("Jankowi zostało: {0} \n", Janek.GetCash());

            IBox pudelkoJanka = new Box(Janek);
            Janek.Pack(pudelkoJanka);

            Console.WriteLine("Pudełko Janka:\n" + pudelkoJanka);

            Console.WriteLine("Żólte kwiaty kosztowały Janka: {0} \n", ValueOf(pudelkoJanka, "Yellow"));
            Console.WriteLine("Jankowi zostało: {0} \n", Janek.GetCash());

        }

        public static int ValueOf(IBox box, string color)
        {
            var oneColorFlowers = box.GetFlowerList()
                                     .Where(x=>x.GetFlowerColor().ToUpper() == color.ToUpper())
                                     .ToList();

            var priceList = PriceList.GetInstance();

            int value = 0;

            foreach (var item in oneColorFlowers)
            {
                value += priceList.GetFlowerCharge(item);
            }

            return value;
        }
    }
}
