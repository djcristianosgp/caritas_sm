using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caritas_SM.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void miCadPessoas_Click(object sender, EventArgs e)
        {
            frmCadPessoa FormCadPessoas = new frmCadPessoa();
            FormCadPessoas.MdiParent = this;
            FormCadPessoas.Show();
        }

        private void miCadCidade_Click(object sender, EventArgs e)
        {
            frmCadCidade FormCadCidades = new frmCadCidade();
            FormCadCidades.MdiParent = this;
            FormCadCidades.Show();
        }
    }
}
