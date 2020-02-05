using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TBP_Skladiste
{
    public class DBCon
    {
        public static NpgsqlConnection BuildConnection()
        {
            NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder();
            builder.Host = "127.0.0.1";
            builder.Port = 5432;
            builder.Username = "postgres";
            builder.Password = "PANASONIC888";
            builder.Database = "TBP_Skladista";
            NpgsqlConnection connection = new NpgsqlConnection(builder.ConnectionString);
            return connection;
            
        }
    }
}
