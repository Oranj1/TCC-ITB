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
            string sqlFind = "select * from escala where escala = " + obj.Id_escala;
            try
            {
                this.abrirConexao();
                this.comando = new SqlCommand(sqlFind, this.con);
                SqlDataReader reader = this.comando.ExecuteReader();
                temRegistro = reader.Read();
                if (temRegistro)
                {
                    obj.Id_escala = reader[0].ToString();
                    obj.Id_func = reader[1].ToString();
                    obj.Id_turno = reader[2].ToString();
                    obj.Dia_semana = reader[3].ToString();
                    obj.Ativo = reader[4].ToString();
                    obj.Horario_termino_intervalo = reader[5].ToString();
                    obj.Horario_intervalo = reader[6].ToString();
                    obj.Periodo = reader[7].ToString();
                    obj.Horario_de_inicio = reader[8].ToString();
                    obj.Horario_de_termino = reader[9].ToString();
                    
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
                    esc.Id_escala = reader[0].ToString();
                    esc.Id_func = reader[1].ToString();
                    esc.Id_turno = reader[2].ToString();
                    esc.Dia_semana = reader[3].ToString();
                    esc.Ativo = reader[4].ToString();
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

