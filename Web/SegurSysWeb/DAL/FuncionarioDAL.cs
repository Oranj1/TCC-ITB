using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FuncionarioDAL : SQLHelper<Funcionario>
    {
        SqlConnection con;
        SqlCommand comando;

        public FuncionarioDAL()
        {
            con = FabricaConexao.getConexao();
        }

        public void abrirConexao()
        {
            if (this.con.State == ConnectionState.Closed)
            {
                this.con.Open();
            }
        }

        public bool autenticarFuncionario(Funcionario objFunc)
        {
            bool result = false;
            string sqlAutenticacao = "select * from funcionario where " +
                "usuario = '" + objFunc.Usuario + "' and senha = '" +
                objFunc.Senha + "' and ativo = '1' and nivel_acesso = '2'";
            try
            {
                this.abrirConexao();
                this.comando = new SqlCommand(sqlAutenticacao, this.con);
                SqlDataReader reader = this.comando.ExecuteReader();
                result = reader.Read();
                if (result)
                {
                    objFunc.Id_func = reader["id_Func"].ToString();
                    objFunc.Nome = reader["nome"].ToString();
                    objFunc.Rg = reader["rg"].ToString();
                    objFunc.Cpf = reader["cpf"].ToString();
                    objFunc.Usuario = reader["usuario"].ToString();
                    objFunc.Senha = reader["senha"].ToString();
                    objFunc.Nivel_acesso = reader["nivel_acesso"].ToString();
                    objFunc.Ativo = reader["ativo"].ToString();
                 
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
            return result;
        }
        public void create(Funcionario obj)
        {
            throw new NotImplementedException();
        }
        public bool find(Funcionario obj)
        {
            bool temRegistro = false;
            string sqlFind = "select * from funcionario where id_func = " + obj.Id_func;
            try
            {
                this.abrirConexao();
                this.comando = new SqlCommand(sqlFind, this.con);
                SqlDataReader reader = this.comando.ExecuteReader();
                temRegistro = reader.Read();
                if (temRegistro)
                {
                    obj.Id_func = reader[0].ToString();
                    obj.Nome = reader[1].ToString();
                    obj.Rg = reader[2].ToString();
                    obj.Cpf = reader[3].ToString();
                    obj.Usuario = reader[4].ToString();
                    obj.Senha = reader[5].ToString();
                    obj.Telefone = reader[6].ToString();
                    obj.Celular = reader[7].ToString();
                    obj.Nivel_acesso = reader[8].ToString();
                    obj.Ativo = reader[9].ToString();
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

        public List<Funcionario> findAll()
        {
            List<Funcionario> listaFuncionario = new List<Funcionario>();
            string sqlFindAll = "select * from funcionario order by id_funcionario";
            try
            {
                this.abrirConexao();
                this.comando = new SqlCommand(sqlFindAll, this.con);
                SqlDataReader reader = this.comando.ExecuteReader();
                while (reader.Read())
                {
                    Funcionario func = new Funcionario();
                    func.Id_func = reader[0].ToString();
                    func.Nome = reader[1].ToString();
                    func.Rg = reader[2].ToString();
                    func.Cpf = reader[3].ToString();
                    func.Usuario = reader[4].ToString();
                    func.Senha = reader[5].ToString();
                    func.Telefone = reader[6].ToString();
                    func.Celular = reader[7].ToString();
                    func.Nivel_acesso = reader[8].ToString();
                    func.Ativo = reader[9].ToString();
                    listaFuncionario.Add(func);
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

            return listaFuncionario;
        }

        List<Funcionario> SQLHelper<Funcionario>.findAll()
        {
            throw new NotImplementedException();
        }       
    }
}
