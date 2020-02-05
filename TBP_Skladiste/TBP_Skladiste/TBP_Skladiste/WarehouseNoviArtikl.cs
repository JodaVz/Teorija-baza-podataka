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
    public partial class WarehouseNoviArtikl : Form
    {
        public NpgsqlConnection connection = DBCon.BuildConnection();
        List<WarehouseItems> artikli = new List<WarehouseItems>();
        public WarehouseNoviArtikl()
        {
            InitializeComponent();
        }

        private void inputOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputPotvrdiUnos_Click(object sender, EventArgs e)
        {
            WarehouseItems artikl = new WarehouseItems();
            try
            {
                //artikl.ArticleName = inputNazivArtikla.Text;
                //artikl.CurrentQuantity = int.Parse (inputTrenutnoStanje.Text);
                //artikl.MinimumQuantity = int.Parse(inputMinimalnaKolicina.Text);
                //artikl.MaximumQuantity = int.Parse(inputMaksimalnaKolicina.Text);
                //artikl.DeliveryDate = DateTime.Parse(inputDostavljen.Value.ToString());
                //artikl.ExpirationDate = DateTime.Parse(inputRokTrajanja.Value.ToString());
                //artikli.Add(artikl);

                ////unos u bazu : RUČAN 29.12
                //connection.Open();
                //NpgsqlCommand command = new NpgsqlCommand("INSERT INTO \"TBP_ERA\".warehouse(ID,articlename,currentquantity,minimumquantity," +
                //    "maximumquantity,deliverydate,expirationdate,deliveredby,registeredby)" +
                //    "VALUES(default,'"+artikl.ArticleName+"',"+artikl.CurrentQuantity+","+artikl.MinimumQuantity+","+artikl.MaximumQuantity+"," +
                //    "'"+artikl.DeliveryDate+"','"+artikl.ExpirationDate+"',1,1);", connection);
                //NpgsqlDataReader dataReader = command.ExecuteReader();
                
                //connection.Close();
                


            }
            catch (Exception ex)
            {

                throw ex;
            }
            OsvjeziPrikaz();
        }
        public void OsvjeziPrikaz()
        {
            //artikli = WarehouseItems.DohvatiArtikle();
            //outputPopisArtikalaNaSkladistu.DataSource = artikli;
        }

        private void inputOsvjeziPrikaz_Click(object sender, EventArgs e)
        {
            OsvjeziPrikaz();
        }
    }
}
