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

            strConnection.Host = "otto.db.elephantsql.com";
            strConnection.Database = "rhvlsdvipc";
            strConnection.Port = 5432;
            strConnection.Username = "rhvlsdvipc";
            strConnection.Password = "0hOdNFJ9ymoTLk_asdai7MxVGla6oy3LCd3u";
            //strConnection.Pooling = false;
            //strConnection.Encoding = "windows-1252";
            //strConnection.ClientEncoding = "UTF8";
            sStringConexao = strConnection.ConnectionString;
        }
    }
}
