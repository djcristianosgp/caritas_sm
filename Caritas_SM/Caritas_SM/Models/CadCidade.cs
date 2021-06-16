using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caritas_SM.Models
{
    public class CadCidade
    {
        public int id_cidade { get; set; }
        public string descricao { get; set; }
        public string cod_ibge { get; set; }
        public int id_estado { get; set; }        
    }
}
