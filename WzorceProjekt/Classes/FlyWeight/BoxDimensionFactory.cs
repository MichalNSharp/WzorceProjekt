using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjekt.Classes.FlyWeight
{
    class BoxDimensionFactory
    {
        // często występujące szerokości pudełek
        private static int[] widths = { 10, 20, 30, 40, 50, 60, 70 };

        // Tablica rzomiarów pudełek - do ponownego użycia (współdzielenia)
        private Dimension[] d = new Dimension[widths.Length];

        private int reused;  // ile razy ponownie użyto gotowego rozmiaru

        // Singleton
        // --- odniesienie do jedynego obiektu fabryki
        private static BoxDimensionFactory bdf;

        // --- prywatny konstruktor
        private BoxDimensionFactory() { }

        // --- metoda zwracająca fabrykę
        public static BoxDimensionFactory getInstance()
        {
            if (bdf == null) bdf = new BoxDimensionFactory(); // jeżeli obiekt nie istnieje -stwórz
            return bdf;                                       // zwróć jedyny obiekt klasy
        }

        // Metoda fabryczna
        // zwraca referencję do obiektu klasy Dimension
        public Dimension makeDimension(int w)
        {
            for (int i = 0; i < widths.Length; i++)
                if (w == widths[i])
                { // jeżeli często występujący rozmiar
                  // jeżeli używany pierwszy raz - utwórz go i zapisz do tablicy
                    if (d[i] == null) d[i] = new Dimension(w, 2 * w);
                    else reused++;  // jeżeli już był utworzony - zwiększ licznik ponownego użycia
                    return d[i];    // zwróć rozmiar - z tablicy "ponownego użycia"
                }
            return new Dimension(w, 2 * w);  // jeżeli jakiś inny rozmiar - utwórz go i zwróć
        }

        // Zwraca liczbę ponownego użycia rozmiarów
        public int reusedCount()
        {
            return reused;
        }

    }
}
