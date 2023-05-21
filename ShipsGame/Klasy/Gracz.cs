using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipsGame.Klasy
{
    public class Gracz
    {
        public string Nazwa;

        public bool[,] OdkrytePola;
        //-1 -> puste
        //0-3 -> pole statu o długości x+1
        public int[,] Plansza;

        public int[] Flota;
        public int LiczbaStatkówDoZatopienia;

        public static int ROZMIAR_PLANSZY = 10;
        public static int OSTATNI_INDEX_PLANSZY = ROZMIAR_PLANSZY - 1;

        public Gracz()
        {
            OdkrytePola = new bool[ROZMIAR_PLANSZY, ROZMIAR_PLANSZY];
            Plansza = new int[ROZMIAR_PLANSZY, ROZMIAR_PLANSZY];

            Flota = new int[] { 1, 2, 3, 4 };
            LiczbaStatkówDoZatopienia = Flota.Length;

            for (int x = 0; x < ROZMIAR_PLANSZY; x++)
            {
                for (int y = 0; y < ROZMIAR_PLANSZY; y++)
                {
                    Plansza[x, y] = -1;
                }
            }
        }
    }
}
