using Caritas_SM.Controllers;
using Caritas_SM.DAO;
using Caritas_SM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caritas_SM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsBanco.StringConexao();
            var sMensagem = CadEstadoDAO.GetAllEstados().ToList();
            MessageBox.Show(sMensagem.ToString());
        }
    }
}
