using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib;

namespace Autobusni_kolodvor_1
{
    public partial class PopisLinija : Form
    {
        KreiranjeKarte kart;

        public PopisLinija(KreiranjeKarte karta)
        {
            InitializeComponent();
            kart = karta;
        }

        private void PopisLinija_Load(object sender, EventArgs e)
        {
            List<Linija> linije = AutobusniKolodvor.DohvatiLinije();

            LinijeDataGridView.DataSource = linije;
        }

        private void OdustaniBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Linija VratiLiniju()
        {
            Linija linija = new Linija();

            if(LinijeDataGridView.CurrentRow != null)
            {
                linija = LinijeDataGridView.CurrentRow.DataBoundItem as Linija;
            }

            return linija;
        }

        private void OdaberiBtn_Click(object sender, EventArgs e)
        {
            Linija linija = VratiLiniju();

            kart.trenutnaLinija = linija;

            Close();
        }
    }
}
