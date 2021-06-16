using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caritas_SM.Models
{
    public class CadPessoa
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public int codigocidade { get; set; }
        public bool ativo { get; set; }
        public DateTime dataregistro { get; set; }
        public bool voluntario  { get; set; }
        public bool funcionario { get; set; }
        public string senha { get; set; }
        public string perfil { get; set; }
    }
}
