using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class TurnoDAL : SQLHelper<Turno>
    {

        private SqlCommand comando;
        private SqlConnection con;

        public TurnoDAL()
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


        public void create(Turno obj)
        {
            throw new NotImplementedException();
        }
        public bool find(Turno obj)
        {
            bool temRegistro = false;
            string sqlFind = "select * from turno where id_turno = " + obj.Id_turno;
            try
            {
                this.abrirConexao();
                this.comando = new SqlCommand(sqlFind, this.con);
                SqlDataReader reader = this.comando.ExecuteReader();
                temRegistro = reader.Read();
                if (temRegistro)
                {
                    obj.Id_turno = reader[0].ToString();
                    obj.Horario_termino_intervalo = reader[1].ToString();
                    obj.Horario_intervalo = reader[2].ToString();
                    obj.Periodo = reader[3].ToString();
                    obj.Horario_de_inicio = reader[4].ToString();
                    obj.Horario_de_termino = reader[5].ToString();
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

        public List<Turno> findAll()
        {
            List<Turno> listaTurno = new List<Turno>();
            string sqlFindAll = "select * from Turno order by id_turno";
            try
            {
                this.abrirConexao();
                this.comando = new SqlCommand(sqlFindAll, this.con);
                SqlDataReader reader = this.comando.ExecuteReader();
                while (reader.Read())
                {
                    Turno tul = new Turno();
                    tul.Id_turno = reader[0].ToString();
                    tul.Horario_termino_intervalo = reader[1].ToString();
                    tul.Horario_intervalo = reader[2].ToString();
                    tul.Periodo = reader[3].ToString();
                    tul.Horario_de_inicio = reader[4].ToString();
                    tul.Horario_de_termino = reader[5].ToString();
                    listaTurno.Add(tul);
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

            return listaTurno;
        }
    }
}
