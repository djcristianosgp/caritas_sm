using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Caritas_SM.Controllers;
using Caritas_SM.Models;

namespace Caritas_SM.DAO
{
    public class CadEstadoDAO
    {
        //private readonly DbContextOptions<DataContext> _contextOptionsApplication;
        //private IConfiguration _config;
        //public ComunidadeDAO(npgs DbContextOptions<DataContext> contextOptionsApplication, IConfiguration configuration)
        //{
        //    _contextOptionsApplication = contextOptionsApplication;
        //    _config = configuration;
        //}

        public List<CadEstado> GetAllEstados()
        {
            string sScript = "select * from cadestados order by descricao;";
            string sResultado = "";
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(clsBanco.sStringConexao);
                conn.Open();
                {
                    {
                        NpgsqlCommand command = new NpgsqlCommand(sScript, conn);

                        //NpgsqlDataReader dr = command.ExecuteReader();
                        var lista = command.ExecuteReader();
                        conn.Close();

                        return GetAllEstados();
                    }
                }
            }
            catch (Exception ex)
            {
                //clsLog.FU_Escreve_Log("FU_ValidaEstacao", ex.Message);
                throw ex;
            }
            finally
            {
                
            }
        }       
    }
}
