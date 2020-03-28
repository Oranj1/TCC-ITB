using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SegurSys
{
    class cldBancoDados
    {
        public static SqlConnection AbreBanco()
        {
            string StringConexao = "Data Source=.\\SQLEX;Initial Catalog=SEGURSYS;User Id=sa;Password=123456;";
            try
            {
                SqlConnection conn = new SqlConnection(StringConexao);
                conn.Open();
                return conn;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void FechaBanco(SqlConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
            catch (Exception e)
            {
                { throw e; }
            }
        }
        public DataTable RetornaTabela(string strQuerry)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmdComando = new SqlCommand(strQuerry, AbreBanco());
                SqlDataAdapter da = new SqlDataAdapter(cmdComando);
                da.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {
                throw new Exception("Erro na pesquisa da Table" + erro.Message);
            }
            finally
            {
                FechaBanco(AbreBanco());
            }
        }
        public SqlDataReader RetornaLinha(string strQuerry)
        {
            try
            {
                SqlDataReader dr;
                SqlCommand sqlComando = new SqlCommand(strQuerry, AbreBanco());
                dr = sqlComando.ExecuteReader();
                return dr;
            }
            catch (Exception e)
            {
                throw e;
                throw new Exception("Mensagem");
            }
        }
        public void ExecutaComando(string strQuerry)
        {
            try
            {
                SqlCommand sqlComm = new SqlCommand(strQuerry, AbreBanco());
                sqlComm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                { FechaBanco(AbreBanco()); }
            }
        }
    }
}
