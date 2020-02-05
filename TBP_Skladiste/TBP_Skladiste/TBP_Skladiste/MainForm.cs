using Npgsql;
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
    public partial class MainForm : Form
    {
        public NpgsqlConnection connection = DBCon.BuildConnection();
        List<string> dataItems = new List<string>();


        public MainForm()
        {
        
        InitializeComponent();
        }

        private void inputTest_Click(object sender, EventArgs e)
        {
        }

        private void inputDodajNoviArtikl_Click(object sender, EventArgs e)
        {
            WarehouseNoviArtikl forma = new WarehouseNoviArtikl();
            forma.Show();
            
        }

        private void unosGlavnaStatistika_Click(object sender, EventArgs e)
        {
            GlavnaStatistikaSkladista forma = new GlavnaStatistikaSkladista();
            forma.Show();
        }
    }
}
