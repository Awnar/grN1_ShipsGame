using ShipsGame.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipsGame.Okna
{
    public partial class Rozgrywka : Form
    {
        int myszX;
        int myszY;

        public Rozgrywka()
        {
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();

            //planszaGracza.Height = 333;
            //planszaGracza.Width = 333;

            //planszaKomputera.Height = 333;
            //planszaKomputera.Width = 333;
        }

        private void planszaGracza_Paint(object sender, PaintEventArgs e)
        {
            Rysowanie.RysujUstawioneKomorki(Gra.Uzytkownik.Plansza, e);
        }

        private void planszaKomputera_Paint(object sender, PaintEventArgs e)
        {
            Rysowanie.RysujUstawioneKomorki(Gra.Komputer.Plansza, e);
        }

        private void planszaKomputera_MouseMove(object sender, MouseEventArgs e)
        {
            myszX = Koordynaty.PobierzKomorke(e.Location.X);
            myszY = Koordynaty.PobierzKomorke(e.Location.Y);

            planszaKomputera.Refresh();

            Rysowanie.RysujObramowanie(myszX, myszY, 4, planszaKomputera);
        }

        private void planszaKomputera_Click(object sender, EventArgs e)
        {
            if (!Gra.Komputer.OdkrytePola[myszX, myszY])
            {
                if (Gra.WykonajAtak(myszX,myszY,Gra.Uzytkownik, Gra.Komputer))
                {
                    planszaGracza.Refresh();

                    if (Gra.Uzytkownik.LiczbaStatkowDoZatopienia == 0)
                    {
                        MessageBox.Show($"Koniec gry. Wygrał: {Gra.Uzytkownik.Nazwa}");
                        planszaKomputera.Enabled = false;
                    }
                }
                else
                {
                    planszaKomputera.Refresh();

                    //TODO: atak komputera
                }
            }
        }

        private void timerRuchKomputera_Tick(object sender, EventArgs e)
        {
            int[] strzalKomputera = Gra.StrzalKomputera(Gra.Uzytkownik);

            if (!Gra.WykonajAtak(strzalKomputera[0], strzalKomputera[1], Gra.Komputer, Gra.Uzytkownik))
            {
                timerRuchKomputera.Stop();
                planszaKomputera.Click += planszaKomputera_Click;
            }

            planszaGracza.Refresh();

            if (Gra.Komputer.LiczbaStatkowDoZatopienia == 0)
            {
                MessageBox.Show($"Koniec gry. Wygrał: {Gra.Komputer.Nazwa}");
                planszaKomputera.Enabled = false;
                timerRuchKomputera.Stop();
            }
        }
    }
}
