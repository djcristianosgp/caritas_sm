using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caritas_SM.Controllers
{
    public class clsBanco
    {
        public static string sStringConexao = "";

        public static void StringConexao()
        {
            NpgsqlConnectionStringBuilder strConnection = new NpgsqlConnectionStringBuilder();

            strConnection.Host = "";
            strConnection.Database = "";
            strConnection.Port = 0;
            strConnection.Username = "";
            strConnection.Password = "pg@rgDev";
            //strConnection.Pooling = false;
            //strConnection.Encoding = "windows-1252";
            //strConnection.ClientEncoding = "UTF8";
            sStringConexao = strConnection.ConnectionString;
        }
    }
}
