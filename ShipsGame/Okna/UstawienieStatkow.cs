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
    public partial class UstawienieStatkow : Form
    {
        int myszX;
        int myszY;

        int indexAktualnegoStatku;

        //pionowe - false
        //poziome - true
        bool poziom;

        bool[] rozmieszczoneStatki = new bool[4];

        public UstawienieStatkow()
        {
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();

            poziom = true;

            Gra.Uzytkownik = new Gracz();
            Gra.Komputer = new Gracz();

            indexAktualnegoStatku = 2;

            lblNazwaGracza.Visible = false;
            btnDalej.Enabled = false;
        }

        private void planszaGracza_MouseMove(object sender, MouseEventArgs e)
        {
            myszX = Koordynaty.PobierzKomorke(e.Location.X);
            myszY = Koordynaty.PobierzKomorke(e.Location.Y);

            planszaGracza.Refresh();

            if(indexAktualnegoStatku < rozmieszczoneStatki.Length)
            {
                //pionowe - false
                //poziome - true
                if (poziom)
                {
                    for (int i = 0; i < Gra.RozmiaryStatkow[indexAktualnegoStatku]; i++)
                    {
                        if (myszX + i <= Gracz.OSTATNI_INDEX_PLANSZY)
                        {
                            Rysowanie.RysujObramowanie(myszX + i, myszY, indexAktualnegoStatku,
                                planszaGracza);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < Gra.RozmiaryStatkow[indexAktualnegoStatku]; i++)
                    {
                        if (myszY + i <= Gracz.OSTATNI_INDEX_PLANSZY)
                        {
                            Rysowanie.RysujObramowanie(myszX, myszY + i, indexAktualnegoStatku,
                                planszaGracza);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
