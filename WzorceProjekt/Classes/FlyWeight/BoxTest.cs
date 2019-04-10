using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjekt.Classes.FlyWeight
{
    class BoxTest
    {
        public void Test()
        {
            // Pobranie fabryki rozmiarów
            BoxDimensionFactory boxDimFac = BoxDimensionFactory.getInstance();

            // na jakie pudełka jest teraz zapotrzebowanie
            int[] potrzebne = { 10, 10, 10, 20, 30, 45, 20, 20, 20, 20, 10,
                        20, 50, 65, 50, 50, 60, 100, 50, 50, 50,
                      };

            // Kolejne pudełka tworzymy na podstawie rozmiarów
            // uzyskanych z fabryki rozmiarów
            // nie wiemy i nie interesuje nas czy rozmiary to nowe obiekty
            // czy też już używane przez inne pudełka
            Box box = null;
            for (int i = 0; i < potrzebne.Length; i++)
                box = new Box(boxDimFac.makeDimension(potrzebne[i]), "Kwiaty");

            Console.WriteLine("Ostatnie pudełko");
            Console.WriteLine(box.ToString());
            Console.WriteLine("Na " + potrzebne.Length + " rozmiarów pudełek\n" +
                  "Utworzono nowych " + (potrzebne.Length - boxDimFac.reusedCount()) +
                  "\nPonownie użyto (przy wspóldzieleniu) " + boxDimFac.reusedCount()
                  );
        }
    }
}
