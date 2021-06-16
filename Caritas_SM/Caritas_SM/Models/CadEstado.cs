using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caritas_SM.Models
{
    public class CadEstado
    {
        public int id_estado { get; set; }
        public string descricao { get; set; }
        public string sigla { get; set; }
        public int id_regiao { get; set; }
        public string pais { get; set; }
    }
}
