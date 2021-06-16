using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Caritas_SM.Controllers;

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

        public List<CadEstadoDAO> GetAllEstados()
        {
            string sScript = "select count(*) from estacoes where estacoes;";
            string sResultado = "";
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(clsBanco.sStringConexao);
                conn.Open();
                {
                    {
                        //var lista1 = conn.CommandTimeout<CadEstadoDAO>(sScript).UnknownResultTypeList();
                        NpgsqlCommand command = new NpgsqlCommand(sScript, conn);
                        //var lista = command.ExecuteNonQuery<CadEstadoDAO>(sScript)

                        //NpgsqlDataReader dr = command.ExecuteReader();
                        var lista = command.ExecuteReader();
                        conn.Close();

                        return lista;
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
