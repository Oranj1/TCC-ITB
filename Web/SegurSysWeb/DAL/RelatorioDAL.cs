using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;

namespace DAL
{
    public class RelatorioDAL : SQLHelper<Relatorio>
    {

        private SqlCommand comando;
        private SqlConnection con;

        public RelatorioDAL()
        {
            this.con = FabricaConexao.getConexao();
        }

        public void abrirConexao()
        {
            if (this.con.State == System.Data.ConnectionState.Closed)
            {
                this.con.Open();
            }
        }


        public void create(Relatorio obj)
        {
            string sqlInsert = "insert into relatorio( data, relatorio_dia, id_func ) " +
                " values('"  + obj.Data + "','" + obj.Relatorio_dia + "','" + obj.Id_func + "')";
            try
            {
                this.abrirConexao();
                this.comando = new SqlCommand(sqlInsert, this.con);
                this.comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.con.Close();
            }
        }
        public bool find(Relatorio obj)
        {
            bool temRegistro = false;
            string sqlFind = "select * from relatorio where id_relatorio = " + obj.Id_relatorio;
            try
            {
                this.abrirConexao();
                this.comando = new SqlCommand(sqlFind, this.con);
                SqlDataReader reader = this.comando.ExecuteReader();
                temRegistro = reader.Read();
                if (temRegistro)
                { obj.Id_relatorio = reader[0].ToString();
                    obj.Data = reader[1].ToString();
                    obj.Relatorio_dia = reader[2].ToString();
                    obj.Id_func = reader[3].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.con.Close();
            }
            return temRegistro;
        }

        public List<Relatorio> findAll()
        {
            List<Relatorio> listaRelatorio = new List<Relatorio>();
            string sqlFindAll = "select * from relatorio order by id_relatorio";
            try
            {
                this.abrirConexao();
                this.comando = new SqlCommand(sqlFindAll, this.con);
                SqlDataReader reader = this.comando.ExecuteReader();
                while (reader.Read())
                {
                    Relatorio rel = new Relatorio();
                    rel.Id_relatorio = reader[0].ToString();
                    rel.Data = reader[1].ToString();
                    rel.Relatorio_dia = reader[2].ToString();
                    rel.Id_func = reader[3].ToString();
                    listaRelatorio.Add(rel);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.con.Close();
            }

            return listaRelatorio;
        }
    }
}
