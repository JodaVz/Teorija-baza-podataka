using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace TBP_Skladiste
{
     public class WarehouseItems
    {
        public int ID { get; set; }
        public string ArticleName { get; set; }
        public int CurrentQuantity { get; set; }
        public int MinimumQuantity { get; set; }
        


        //static public List<WarehouseItems> DohvatiArtikle()
        //{
        //    List<WarehouseItems> artikli = new List<WarehouseItems>();
            
        //    NpgsqlConnection connection = DBCon.BuildConnection();
        //    connection.Open();
        //    NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"TBP_ERA\".warehouse", connection);
        //    NpgsqlDataReader dataReader = command.ExecuteReader();
        //    for (int i = 0; dataReader.Read(); i++)
        //    {
        //        WarehouseItems artikl = new WarehouseItems();
        //        artikl.ID = int.Parse(dataReader[0].ToString());
        //        artikl.ArticleName = dataReader[1].ToString();
        //        artikl.CurrentQuantity = int.Parse(dataReader[2].ToString());
        //        artikl.MinimumQuantity = int.Parse(dataReader[3].ToString());
        //        artikl.MaximumQuantity = int.Parse(dataReader[4].ToString());
        //        artikl.DeliveryDate =   DateTime.Parse(dataReader[5].ToString());
        //        artikl.ExpirationDate = DateTime.Parse(dataReader[6].ToString());
        //       // artikl.DeliveredBy = int.Parse(dataReader[6].ToString());
        //       // artikl.RegisteredBy = int.Parse(dataReader[6].ToString());
        //        artikli.Add(artikl);

        //    }
        //    connection.Close();
        //    return artikli;
        //}
        //Metoda za automatsko generiranje n stvari na skladistu
        public static void PopuniSkladiste()
        {
            Random random = new Random();
            NpgsqlConnection connection = DBCon.BuildConnection();
            List<WarehouseItems> popisArtikalaUSkladistu = new List<WarehouseItems>();
           
            
            for (int i = 0; i < StatickaPomocnaKlasa.ListaArtikala().Count(); i++)
            {
                
                popisArtikalaUSkladistu.Add(new WarehouseItems()
                {
                    ID = 1,
                    ArticleName = StatickaPomocnaKlasa.ListaArtikala().ElementAt(i),
                    CurrentQuantity = 0,
                    MinimumQuantity = random.Next(20, 50),
                    
                });
            }

            connection.Open();
            foreach (var artikl in popisArtikalaUSkladistu)
            {
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO \"TBP_ERA\".warehouse(ID,articlename,currentquantity,minimumquantity)" +
               "VALUES(default,'" + artikl.ArticleName + "'," + artikl.CurrentQuantity + "," + artikl.MinimumQuantity +");", connection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (NpgsqlException ex)
                {
                    string nekej = ex.ToString();
                    throw;
                }
                System.Threading.Thread.Sleep(1000);
            }
           


            connection.Close();

            
        }
        //Metoda za brisanje svih artikala sa skladista
        public static void IsprazniSkladiste()
        {
            NpgsqlConnection connection = DBCon.BuildConnection();
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("DELETE FROM \"TBP_ERA\".warehouse",connection);
                
            NpgsqlDataReader dataReader = command.ExecuteReader();

            connection.Close();

        }

        static public List<WarehouseItems> DohvatiSveNaSkladistu()
        {
            List<WarehouseItems> artikli = new List<WarehouseItems>();
           

            NpgsqlConnection connection = DBCon.BuildConnection();
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"TBP_ERA\".warehouse order by articlename", connection);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            for (int i = 0; dataReader.Read(); i++)
            {
                WarehouseItems artikl = new WarehouseItems();
                artikl.ID = int.Parse(dataReader[0].ToString());
                artikl.ArticleName = dataReader[1].ToString();
                artikl.CurrentQuantity =int.Parse (dataReader[2].ToString());
                artikl.MinimumQuantity = int.Parse(dataReader[3].ToString());
                

                artikli.Add(artikl);

            }
            connection.Close();
            return artikli;

        }
        //Ovo je kraj 
    }
    //Metoda za ručno dodavanje stvari na skladiste




    //Metoda za dohvat svih stvari na skladistu :) 


}
