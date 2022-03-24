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

namespace Kolodvor1
{
    public partial class Form1 : Form
    {
        public Linija odabranaLinija { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLinija_Click(object sender, EventArgs e)
        {
            Popis_autobusnih_linija x = new Popis_autobusnih_linija();
            var rezultat = x.ShowDialog();
            if (rezultat == DialogResult.OK)
            {
                odabranaLinija = x.odabranaLinija;
                txtPolaziste.Text = odabranaLinija.Polaziste;
                txtOdrediste.Text = odabranaLinija.Odrediste;
                txtUdaljenost.Text = Convert.ToString(odabranaLinija.Udaljenost);
                txtAutoprijevoznik.Text = odabranaLinija.Autoprijevoznik;
            }
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            VrstaKarte vrstaKarte = this.radioRegularna.Checked ? VrstaKarte.Regularna : VrstaKarte.Studentska;
            bool povratnaKarta = this.checkPovratna.Checked;
            bool prtljaga = this.checkPrtljaga.Checked;
            Karta novaKarta = new Karta(odabranaLinija, vrstaKarte, povratnaKarta, prtljaga);
            this.txtCijena.Text = novaKarta.Cijena.ToString();
            this.txtBrojKarte.Text = novaKarta.BrojKarte.ToString();
        }
    }
}
