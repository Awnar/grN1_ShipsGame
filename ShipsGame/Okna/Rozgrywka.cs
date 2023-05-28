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
        public Rozgrywka()
        {
            InitializeComponent();
        }

        private void planszaGracza_Paint(object sender, PaintEventArgs e)
        {
            Rysowanie.RysujUstawioneKomorki(Gra.Uzytkownik.Plansza, e);
        }

        private void planszaKomputera_Paint(object sender, PaintEventArgs e)
        {
            Rysowanie.RysujUstawioneKomorki(Gra.Komputer.Plansza, e);
        }
    }
}
