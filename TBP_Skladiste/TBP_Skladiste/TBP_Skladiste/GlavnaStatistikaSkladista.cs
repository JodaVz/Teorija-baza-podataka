using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBP_Skladiste
{
    public partial class GlavnaStatistikaSkladista : Form
    {
        public List<Buyer> kupci = new List<Buyer>();
        public List<Buyer> kupciUProcesu = new List<Buyer>();
        public List<Buyer> kupciZavrseni = new List<Buyer>();
        public List<WarehouseItems> artikli = new List<WarehouseItems>();
        public List<string> narudzbe = new List<string>();
        
        public GlavnaStatistikaSkladista()
        {

            InitializeComponent();
        }

        private void inputOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputPocetakNarudzbi_Click(object sender, EventArgs e)
        {
            
            Brojac.Enabled = true;
            
            
        }
        public void OsvjeziPrikaz()
        {
            artikli = WarehouseItems.DohvatiSveNaSkladistu();
            kupciUProcesu = Buyer.DohvatiKupceUProcesu();
            kupciZavrseni = Buyer.DohvatiKupceKrajNarudzbe();
            narudzbe = Buyer.DohvatiKupce();
            kupci = Buyer.DohvatiKupceObjekt();
            outputNarudzbe.Text = string.Join(Environment.NewLine, narudzbe);
            dgvPrikazUProcesu.DataSource = kupciUProcesu;
            dgvPrikazUProcesu.FirstDisplayedScrollingRowIndex = dgvPrikazUProcesu.RowCount - 1;
            dgvKrajNarudzbe.DataSource = kupciZavrseni;
            dgvKrajNarudzbe.FirstDisplayedScrollingRowIndex = dgvKrajNarudzbe.RowCount - 1;
            outputKupac.DataSource = kupci;
            prikazStanjaSkladista.DataSource = artikli;
            prikazStanjaSkladista.Series["Minimalnakolicina"].XValueMember = "ArticleName";
            prikazStanjaSkladista.Series["Minimalnakolicina"].YValueMembers = "MinimumQuantity";
            prikazStanjaSkladista.Series["Trenutnakolicina"].XValueMember = "ArticleName";
            prikazStanjaSkladista.Series["Trenutnakolicina"].YValueMembers = "CurrentQuantity";
            prikazStanjaSkladista.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            prikazStanjaSkladista.ChartAreas["ChartArea1"].AxisY.Minimum = 0;
            prikazStanjaSkladista.ChartAreas["ChartArea1"].AxisY.Maximum = 100;
            outputUProcesu.Text = Buyer.BrojZapocetihNarudzbi().ToString();
            outputZavrsene.Text = Buyer.BrojZavrsenih().ToString();

            prikazStanjaSkladista.DataBind();
        }

        private void Brojac_Tick(object sender, EventArgs e)
        {
            OsvjeziPrikaz();
            Buyer.DodajKupca();
            
        }

        private void inputZaustavi_Click(object sender, EventArgs e)
        {
            Brojac.Enabled = false;
        }

        private void outputNarudzbe_TextChanged(object sender, EventArgs e)
        {
            outputNarudzbe.SelectionStart = outputNarudzbe.Text.Length;
            outputNarudzbe.ScrollToCaret();
        }

        private void inputPopuniSkladiste_Click(object sender, EventArgs e)
        {
            WarehouseItems.IsprazniSkladiste();
            WarehouseItems.PopuniSkladiste();
        }
    }
}
