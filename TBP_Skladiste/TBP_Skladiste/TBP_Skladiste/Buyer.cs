using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TBP_Skladiste
{
    public class Buyer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        //0,1,2 odluci jos kaj bus s tim ? !
        public int OrderCompleted { get; set; }
        public DateTime OrderedAt { get; set; }
        public DateTime CompletedAt { get; set; }


        public static void DodajKupca()
        {
            NpgsqlConnection connection = DBCon.BuildConnection();
            List<string> popisArtikala = new List<string>();
            popisArtikala.Add("Bambus");
            popisArtikala.Add("Ruza");
            popisArtikala.Add("Jaglac");
            popisArtikala.Add("Tratinicica");
            popisArtikala.Add("Kukuruz");
            popisArtikala.Add("Ljubenica");
            popisArtikala.Add("Kupus");
            popisArtikala.Add("Luk");
            popisArtikala.Add("Cesnjak");
            popisArtikala.Add("Rotkvica");
            popisArtikala.Add("Tikvica");
            popisArtikala.Add("Ananas");
            popisArtikala.Add("Kiwi");
            popisArtikala.Add("Jecam");
            popisArtikala.Add("Psenica");
            popisArtikala.Add("Cikla");
            popisArtikala.Add("Secerna trska");
            popisArtikala.Add("Kupina");

            List<string> popisKupaca = new List<string>();
            popisKupaca.Add("Marko");
            popisKupaca.Add("Mirko");
            popisKupaca.Add("Markus");
            popisKupaca.Add("Zlatko");
            popisKupaca.Add("Ivan");
            popisKupaca.Add("Joza");
            popisKupaca.Add("Barica");
            
            popisKupaca.Add("Regica");
            popisKupaca.Add("Cedomil");
            popisKupaca.Add("Sandra");
            popisKupaca.Add("Vida");
            popisKupaca.Add("John");
            popisKupaca.Add("Leni");
            popisKupaca.Add("Bela");
            popisKupaca.Add("Petar");
            
            Random random = new Random();
            var index = random.Next(StatickaPomocnaKlasa.ListaArtikala().Count);
            var artikl = StatickaPomocnaKlasa.ListaArtikala()[index];
            index = random.Next(popisKupaca.Count);
            var kupac = popisKupaca[index];

            Buyer buyer = new Buyer();

            int kolicina = random.Next(100);
            buyer.Name = kupac;
            buyer.ProductName = artikl;
            buyer.ProductQuantity =kolicina;

            //unos u bazu : RUČAN 29.12
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO \"TBP_ERA\".buyer(ID,name,productname,productquantity,ordercompleted)" +
                " VALUES(default,'" + buyer.Name + "','" + buyer.ProductName + "'," + buyer.ProductQuantity+",0);", connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                string nekej = ex.ToString();
                throw;
            }
            

            connection.Close();


        }
        static public List<string> DohvatiKupce()
        {
            List<Buyer> kupci = new List<Buyer>();
            List<string> popisZahtjeva = new List<string>();
            string zahtjev = "";

            NpgsqlConnection connection = DBCon.BuildConnection();
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"TBP_ERA\".buyer", connection);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            for (int i = 0; dataReader.Read(); i++)
            {
                Buyer kupac = new Buyer();
                kupac.ID = int.Parse(dataReader[0].ToString());
                kupac.Name = dataReader[1].ToString();
                kupac.ProductName = dataReader[2].ToString();
                kupac.ProductQuantity = int.Parse(dataReader[3].ToString());
                kupac.OrderCompleted = int.Parse(dataReader[4].ToString());
                kupac.OrderedAt = DateTime.Parse(dataReader[5].ToString());
                if(dataReader[6]!=DBNull.Value) kupac.CompletedAt = DateTime.Parse(dataReader[6].ToString());
                if(kupac.OrderCompleted==0) zahtjev = "Kupac " + kupac.Name + " zeli kupiti " + kupac.ProductQuantity + " komada " + kupac.ProductName + " narucenih datuma " + kupac.OrderedAt.Date + " u " + kupac.OrderedAt.TimeOfDay + " sati.";
                if (kupac.OrderCompleted == 1) zahtjev = "Narudzba za " + kupac.ProductName + " od " + kupac.ProductQuantity + " komada, kupca " + kupac.Name + " je krenula u proces nabave";
                if (kupac.OrderCompleted == 2) zahtjev = "Narudzba za " + kupac.ProductName + " od " + kupac.ProductQuantity + " komada, kupca " + kupac.Name + " je zavrsila u " + kupac.CompletedAt;
                    popisZahtjeva.Add(zahtjev);

                kupci.Add(kupac);

            }
            connection.Close();
            return popisZahtjeva;
            //return kupci;
        }
        static public List<Buyer> DohvatiKupceObjekt()
        {
            List<Buyer> kupci = new List<Buyer>();
            List<string> popisZahtjeva = new List<string>();
            string zahtjev = "";

            NpgsqlConnection connection = DBCon.BuildConnection();
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"TBP_ERA\".buyer WHERE NOT completedat is null", connection);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            for (int i = 0; dataReader.Read(); i++)
            {
                Buyer kupac = new Buyer();
                kupac.ID = int.Parse(dataReader[0].ToString());
                kupac.Name = dataReader[1].ToString();
                kupac.ProductName = dataReader[2].ToString();
                kupac.ProductQuantity = int.Parse(dataReader[3].ToString());
                kupac.OrderCompleted = int.Parse(dataReader[4].ToString());
                kupac.OrderedAt = DateTime.Parse(dataReader[5].ToString());
                if (dataReader[6] != DBNull.Value) kupac.CompletedAt = DateTime.Parse(dataReader[6].ToString());
                
                kupci.Add(kupac);

            }
            connection.Close();
            return kupci;
            
        }
        static public List<Buyer> DohvatiKupceUProcesu()
        {
            List<Buyer> kupci = new List<Buyer>();
            List<string> popisZahtjeva = new List<string>();
            string zahtjev = "";

            NpgsqlConnection connection = DBCon.BuildConnection();
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"TBP_ERA\".buyer WHERE NOT completedat is null and ordercompleted=1 order by orderedat", connection);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            for (int i = 0; dataReader.Read(); i++)
            {
                Buyer kupac = new Buyer();
                kupac.ID = int.Parse(dataReader[0].ToString());
                kupac.Name = dataReader[1].ToString();
                kupac.ProductName = dataReader[2].ToString();
                kupac.ProductQuantity = int.Parse(dataReader[3].ToString());
                kupac.OrderCompleted = int.Parse(dataReader[4].ToString());
                kupac.OrderedAt = DateTime.Parse(dataReader[5].ToString());
                if (dataReader[6] != DBNull.Value) kupac.CompletedAt = DateTime.Parse(dataReader[6].ToString());

                kupci.Add(kupac);

            }
            connection.Close();
            return kupci;

        }
        static public List<Buyer> DohvatiKupceKrajNarudzbe()
        {
            List<Buyer> kupci = new List<Buyer>();
            List<string> popisZahtjeva = new List<string>();
            string zahtjev = "";

            NpgsqlConnection connection = DBCon.BuildConnection();
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"TBP_ERA\".buyer WHERE NOT completedat is null and ordercompleted=2 order by completedat", connection);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            for (int i = 0; dataReader.Read(); i++)
            {
                Buyer kupac = new Buyer();
                kupac.ID = int.Parse(dataReader[0].ToString());
                kupac.Name = dataReader[1].ToString();
                kupac.ProductName = dataReader[2].ToString();
                kupac.ProductQuantity = int.Parse(dataReader[3].ToString());
                kupac.OrderCompleted = int.Parse(dataReader[4].ToString());
                kupac.OrderedAt = DateTime.Parse(dataReader[5].ToString());
                if (dataReader[6] != DBNull.Value) kupac.CompletedAt = DateTime.Parse(dataReader[6].ToString());

                kupci.Add(kupac);

            }
            connection.Close();
            return kupci;

        }
        static public int BrojZapocetihNarudzbi()
        {

            int rezultat = 0;
            NpgsqlConnection connection = DBCon.BuildConnection();
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT COUNT(*) FROM \"TBP_ERA\".buyer WHERE ordercompleted=1", connection);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            for (int i = 0; dataReader.Read(); i++)
            {
                
                rezultat = int.Parse(dataReader[0].ToString());
                

            }
            connection.Close();
            return rezultat;

        }
        static public int BrojZavrsenih()
        {

            int rezultat = 0;
            NpgsqlConnection connection = DBCon.BuildConnection();
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT COUNT(*) FROM \"TBP_ERA\".buyer WHERE ordercompleted=2", connection);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            for (int i = 0; dataReader.Read(); i++)
            {

                rezultat = int.Parse(dataReader[0].ToString());


            }
            connection.Close();
            return rezultat;

        }
    }
}
