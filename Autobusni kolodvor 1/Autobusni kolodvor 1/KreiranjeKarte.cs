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
    public partial class KreiranjeKarte : Form
    {
        public Linija trenutnaLinija { get; set; }
        public KreiranjeKarte()
        {
            InitializeComponent();
        }

        private void OdabirLinijeBtn_Click(object sender, EventArgs e)
        {
            trenutnaLinija = null;
            PopisLinija form = new PopisLinija(this);
            form.ShowDialog();

            PopuniPolja();
        }

        private void PopuniPolja()
        {
            PolazisteTxt.Text = trenutnaLinija.Polaziste.ToString();
            OdredisteTxt.Text = trenutnaLinija.Odrediste.ToString();
            UdaljenostTxt.Text = trenutnaLinija.Udaljenost.ToString();
            AutoprijevoznikTxt.Text = trenutnaLinija.Autoprijevoznik.ToString();
        }

        private void KreirajBtn_Click(object sender, EventArgs e)
        {
            VrstaKarte vrsta = VrstaKarte.Regularna;
            if(StudentskaKartaRadBtn.Checked)
            {
                vrsta = VrstaKarte.Studentska;
            }

            Karta karta = AutobusniKolodvor.KreirajKartu(trenutnaLinija, vrsta, PovratnaCheckBox.Checked, PrtljagaCheckBox.Checked);

            if(karta != null)
            {
                BrojKarteTxtBox.Text = karta.BrojKarte.ToString();
                CijenaTxtBox.Text = karta.Cijena.ToString();
            }
        }
    }
}
