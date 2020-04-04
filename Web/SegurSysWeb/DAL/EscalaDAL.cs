using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;


namespace DAL
{
    public class EscalaDAL : SQLHelper<Escala>
    {
        private SqlCommand comando;
        private SqlConnection con;

        public EscalaDAL()
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

        public void create(Escala obj)
        {
            throw new NotImplementedException();
        }

        public bool find(Escala obj)
        {
        
            bool temRegistro = false;
            string sqlFind = "select horario_de_inicio,horario_de_termino from turno inner join escala on Turno.id_turno = Escala.id_turno " +
                "where dia_semana = '"+obj.Dia_semana+"' and Escala.id_func = '"+obj.Id_func+"' and Escala.ativo = '1'";
            try
            {
                this.abrirConexao();
                this.comando = new SqlCommand(sqlFind, this.con);
                SqlDataReader reader = this.comando.ExecuteReader();
                temRegistro = reader.Read();
                if (temRegistro)
                {
                    obj.Horario_de_inicio = reader[0].ToString();
                    obj.Horario_de_termino = reader[1].ToString();
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

        public List<Escala> findAll()
        {
            List<Escala> listaEscala = new List<Escala>();
            string sqlFindAll = "select * from escala order by id_escala";
            try
            {
                this.abrirConexao();
                this.comando = new SqlCommand(sqlFindAll, this.con);
                SqlDataReader reader = this.comando.ExecuteReader();
                while (reader.Read())
                {
                    Escala esc = new Escala();
                    esc.Id_escala = reader["id_escala"].ToString();
                    esc.Id_func = reader["id_func"].ToString();
                    esc.Id_turno = reader["id_turno"].ToString();
                    esc.Dia_semana = reader["dia_semana"].ToString();
                    esc.Ativo = reader["ativo"].ToString();
                    esc.Horario_termino_intervalo = reader[5].ToString();
                    esc.Horario_intervalo = reader[6].ToString();
                    esc.Periodo = reader[7].ToString();
                    esc.Horario_de_inicio = reader[8].ToString();
                    esc.Horario_de_termino = reader[9].ToString();
                    listaEscala.Add(esc);
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

            return listaEscala;
        }


    }
}

