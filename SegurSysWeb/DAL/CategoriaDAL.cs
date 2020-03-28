using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;



namespace DAL
{
    public class CategoriaDAL : SQLHelper<Categoria>
    {

        private SqlCommand comando;
        private SqlConnection con;

        public CategoriaDAL()
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


        public void create(Categoria obj)
        {
            string sqlInsert = "insert into categoria(nome_categoria, desc_categoria, status_categoria) " +
                " values('" + obj.NomeCategoria + "','" + obj.DescrCategoria + "','" + obj.StatusCategoria + "')";
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

        public void delete(Categoria obj)
        {
            string sqlDelete = "delete from categoria where id_categoria =" + obj.IdCategoria;
            try
            {
                this.abrirConexao();
                this.comando = new SqlCommand(sqlDelete, this.con);
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

        public bool find(Categoria obj)
        {
            bool temRegistro = false;
            string sqlFind = "select * from categoria where id_categoria = " + obj.IdCategoria;
            try
            {
                this.abrirConexao();
                this.comando = new SqlCommand(sqlFind, this.con);
                SqlDataReader reader = this.comando.ExecuteReader();
                temRegistro = reader.Read();
                if (temRegistro)
                {
                    obj.NomeCategoria = reader[1].ToString();
                    obj.DescrCategoria = reader[2].ToString();
                    obj.StatusCategoria = reader[3].ToString();
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

        public List<Categoria> findAll()
        {
            List<Categoria> listaCategoria = new List<Categoria>();
            string sqlFindAll = "select * from categoria order by nome_categoria";
            try
            {
                this.abrirConexao();
                this.comando = new SqlCommand(sqlFindAll, this.con);
                SqlDataReader reader = this.comando.ExecuteReader();
                while (reader.Read())
                {
                    Categoria cat = new Categoria();
                    cat.IdCategoria = Convert.ToInt32(reader[0].ToString());
                    cat.NomeCategoria = reader[1].ToString();
                    cat.DescrCategoria = reader[2].ToString();
                    cat.StatusCategoria = reader[3].ToString();
                    listaCategoria.Add(cat);
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

            return listaCategoria;
        }

        public void update(Categoria obj)
        {
            string sqlUpdate = "update categoria set " +
                " nome_categoria = '" + obj.NomeCategoria + "'" +
                ", desc_categoria = '" + obj.DescrCategoria + "'" +
                ", status_categoria = '" + obj.StatusCategoria + "'" +
                " where id_categoria = " + obj.IdCategoria;
            try
            {
                this.abrirConexao();
                this.comando = new SqlCommand(sqlUpdate, this.con);
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
    }
}
