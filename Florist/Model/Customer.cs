using Florist.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist.Model
{
    class Customer : ICustomer
    {
        private string Name { get; set; }

        private int Cash { get; set; }

        private ShoppingCart shoppingCart = new ShoppingCart();

        private PriceList priceList;

        public Customer(string imie, int cash)
        {
            this.Name = imie;
            this.Cash = cash;
        }

        public ShoppingCart GetShoppingCart()
        {
            return shoppingCart;
        }

        public void GetFlower(IFlower flower)
        {
            shoppingCart.AddToCart(flower);
        }

        public void Pay()
        {
            priceList = PriceList.GetInstance();

            List<IFlower> flowerToRemove = new List<IFlower>();

            foreach (IFlower item in shoppingCart.GetFlowers())
            {
                if (priceList.IfFlowerExistInPriceList(item))
                {
                    var charge = priceList.GetFlowerCharge(item);
                    if (Cash >= charge)
                    {
                        Cash -= charge;
                    }
                    else
                    {
                        flowerToRemove.Add(item);
                    }
                }
                else
                {
                    flowerToRemove.Add(item);
                }
            }

            foreach (var item in flowerToRemove)
            {
                shoppingCart.RemoveFromCart(item);
            }

        }

        public int GetCash()
        {
            return Cash;
        }

        public string GetCustomerName()
        {
            return Name;
        }

        public void Pack(IBox box)
        {
            foreach (var item in shoppingCart.GetFlowers())
            {
                box.AddFlowerToBox(item);
            }

            shoppingCart.ClearShoppingCart();
        }
    }
}
