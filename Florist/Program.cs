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
            IFlowerFactory flowerFactory = new FlowerFactory();

            //#################
            FloristShop floristShop = new FloristShop();

            ICustomer Janek = new Customer("Janek", 70);
            Console.WriteLine(Janek.ShowDetails());

            Janek.GetFlower(flowerFactory.CreateFlower(FlowerType.Rose,5));
            Janek.GetFlower(flowerFactory.CreateFlower(FlowerType.Daisy, 3));
            Janek.GetFlower(flowerFactory.CreateFlower(FlowerType.Iris, 2));

            ShoppingCart shoppingCart = Janek.GetShoppingCart();

            Console.WriteLine("Wózek Janka:\n" + shoppingCart);
            Janek.Pay();
            Console.WriteLine("Wózek Janka po zapłaceniu:\n" + shoppingCart);
            Console.WriteLine("Jankowi zostało: {0:C} \n", Janek.GetCash());

            IBox pudelkoJanka = new Box(Janek);
            Janek.Pack(pudelkoJanka);

            Console.WriteLine("Pudełko Janka:\n" + pudelkoJanka.ShowDetails());

            Console.WriteLine("Żólte kwiaty kosztowały Janka: {0:C} \n", ValueOf(pudelkoJanka, "Yellow"));
            Console.WriteLine("Jankowi zostało: {0:C} \n", Janek.GetCash());


            //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

            ICustomer Franek = new Customer("Franek", 300);
            Franek.GetFlower(new Iris(9));
            Franek.GetFlower(new Rose(9));
            Franek.GetFlower(new Daisy(4));

            Console.WriteLine("Wózek Franka:\n" + Franek.GetShoppingCart());
            Franek.Pay();
            Console.WriteLine("Wózek Franka po zapłaceniu:\n" + Franek.GetShoppingCart());
            Console.WriteLine("Frankowi zostało: {0} \n", Franek.GetCash());

            IBox torbaFranka = new Box(Franek);
            Franek.Pack(torbaFranka);

            Console.WriteLine(torbaFranka.ShowDetails());
            Console.WriteLine("Żólte kwiaty kosztowały Franka: {0} \n", ValueOf(torbaFranka, "Yellow"));
            Console.WriteLine("Frankowi zostało: {0} \n", Franek.GetCash());
        }

        public static int ValueOf(IBox box, string color)
        {
            var oneColorFlowers = box.GetFlowerList()
                                     .Where(x=>x.GetFlowerColor().ToUpper() == color.ToUpper())
                                     .ToList();
            
            int value = 0;

            foreach (var item in oneColorFlowers)
            {
                value += PriceList.GetInstance().GetFlowerCharge(item);
            }

            return value;
        }
    }
}
