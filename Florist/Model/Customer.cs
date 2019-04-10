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
        public string Imie { get; set; }

        public int Cash { get; set; }

        private ShoppingCart shoppingCart = new ShoppingCart();

        private PriceList priceList = PriceList.GetInstance();

        public Customer(string imie, int cash)
        {
            this.Imie = imie;
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
            
        }
    }
}
