using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SegurSys
{
    class clnFuncionario
    {
        string comando;
        cldBancoDados ObjBancoDados = new cldBancoDados();
        clnPesquisar ObjClnPesquisar = new clnPesquisar();

        private string _id, _nome, _cel, _tel, _cpf, _rg, _iniTurno, _fimTurno, _iniInterval, _fimInterval, _user, _pass, _periodo, _diaSemana;
    
        public string Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cel { get => _cel; set => _cel = value; }
        public string Tel { get => _tel; set => _tel = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public string IniTurno { get => _iniTurno; set => _iniTurno = value; }
        public string FimTurno { get => _fimTurno; set => _fimTurno = value; }
        public string IniInterval { get => _iniInterval; set => _iniInterval = value; }
        public string FimInterval { get => _fimInterval; set => _fimInterval = value; }
        public string User { get => _user; set => _user = value; }
        public string Pass { get => _pass; set => _pass = value; }
        public string DiaSemana { get => _diaSemana; set => _diaSemana = value; }


        public void Alterar()
        {
            comando = "update Funcionario set ";
            comando += "nome = '" + _nome + "', ";
            comando += "cpf = '" + _cpf + "', ";
            comando += "rg = '" + _rg + "', ";
            comando += "celular = '" + _cel + "', ";
            comando += "telefone = '" + _tel + "', ";
            comando += "usuario = '" + _user + "', ";
            comando += "senha = '" + _pass + "' ";
            comando += "where id_func = '" + _id + "'";
            ObjBancoDados.ExecutaComando(comando);
        }

        public void Registrar()
        {
            comando = "INSERT INTO Funcionario (cpf, telefone, celular, rg, nome, usuario, senha, nivel_acesso, ativo) VALUES ";
            comando += "('" + _cpf +"', ";
            comando += "'" + _tel + "', ";
            comando += "'" + _cel + "', ";
            comando += "'" + _rg + "', ";
            comando += "'" + _nome + "', ";
            comando += "'" + _user + "', ";
            comando += "'" + _pass + "', ";
            comando += "'2', ";
            comando += "'1')";
            ObjBancoDados.ExecutaComando(comando);
        }
        public static string CalcularPeriodo(string inicioTurno, string fimTurno)
        {
            inicioTurno = inicioTurno.Replace(":", "");
            fimTurno = fimTurno.Replace(":", "");
            int parte1 = Convert.ToInt32(inicioTurno);
            int parte2 = Convert.ToInt32(fimTurno);
            if (parte1 >= 2200 || parte1 <= 0500 || parte2 >= 2200 || parte2 <= 0500)
            {
                return "Noturno";
            }
            else
            {
                return "Diurno";
            }
        }

        public void ExclusaoLogica()
        {
            comando = "update Funcionario set ";
            comando += "ativo = '0'";
            comando += "where id_func = '" + _id + "'";
            ObjBancoDados.ExecutaComando(comando);
        }
        public void EscalarTurno()
        {
            _periodo = CalcularPeriodo(_iniTurno, _fimTurno);
            comando = "INSERT INTO Turno (horario_de_inicio, horario_de_termino, horario_intervalo, horario_termino_intervalo, periodo) VALUES (";
            comando += "'" + _iniTurno + "', ";
            comando += "'" + _fimTurno + "', ";
            comando += "'" + _iniInterval + "', ";
            comando += "'" + _fimInterval + "', ";
            comando += "'" + _periodo + "')";
            ObjBancoDados.ExecutaComando(comando);
        }
        public void AlterarEscala()
        {
            _periodo = CalcularPeriodo(_iniTurno, _fimTurno);
            comando = "update Turno set ";
            comando += "horario_de_inicio = '" + _iniTurno + "', ";
            comando += "horario_de_termino = '" + _fimTurno + "', ";
            comando += "horario_intervalo = '" + _iniInterval + "', ";
            comando += "horario_termino_intervalo = '" + _fimInterval + "', ";
            comando += "periodo = '" + _periodo + "' ";
            SqlDataReader DescobreIdTurno;
            DescobreIdTurno = ObjClnPesquisar.AchaTurnoPorIdComDia(_id, _diaSemana);
            DescobreIdTurno.Read();
            string _idTurno = DescobreIdTurno["id_turno"].ToString();
            comando += "where id_turno = '" + _idTurno + "'";
            ObjBancoDados.ExecutaComando(comando);
            comando = "update Escala set ";
            comando += "ativo = '1'";
            comando += "where id_turno = '" + _idTurno + "' and id_func = '" + _id + "'";
            ObjBancoDados.ExecutaComando(comando);
        }

        public void NaoTrabalha()
        {
            comando = "update Escala set ";
            comando += "ativo = '0' ";
            SqlDataReader DescobreIdTurno;
            DescobreIdTurno = ObjClnPesquisar.AchaTurnoPorID(_id);
            DescobreIdTurno.Read();
            string _idFunc = DescobreIdTurno["id_func"].ToString();
            comando += "where id_func = '" + _idFunc + "' and dia_semana = '" + _diaSemana + "'";
            ObjBancoDados.ExecutaComando(comando);
        }
        public void FazerLigacaoTurnoFunc()
        {
            SqlDataReader UltimoId;
            UltimoId = ObjClnPesquisar.UltimoRegistroInserido();
            UltimoId.Read();
            string _idTurno = UltimoId["id_Turno"].ToString();
            comando = "INSERT INTO Escala (id_func, id_turno, dia_semana, ativo) VALUES (";
            comando += "'" + _id + "', ";
            comando += "'" + _idTurno + "', ";
            comando += "'" + _diaSemana + "', ";
            comando += "'1')";
            ObjBancoDados.ExecutaComando(comando);
        }

        public void RegistrarAdm()
        {
            comando = "INSERT INTO Funcionario (nome, usuario, senha, nivel_acesso, ativo) VALUES ('Adiministrador', '";
            comando += _user + "', '";
            comando += _pass + "', '1', '1') ";
            comando += "INSERT INTO Turno (horario_de_inicio, horario_de_termino, horario_intervalo, horario_termino_intervalo, periodo) VALUES ('00:00', '00:00', '00:00', '00:00', 'Noturno') ";
            ObjBancoDados.ExecutaComando(comando);
            LigarAdm();
        }
        public void LigarAdm()
        {
            string _admTurn = "", _admFunc = "";
            SqlDataReader UltimoId, UltimoTurno;
            UltimoTurno = ObjClnPesquisar.UltimoRegistroInserido();
            UltimoId = ObjClnPesquisar.UltimoRegistroFunc();

            if (UltimoId.Read())
            {
                _admFunc = UltimoId["id_func"].ToString();
            }

            if (UltimoTurno.Read())
            {
                _admTurn = UltimoTurno["id_turno"].ToString();
            }

            comando = "INSERT INTO Escala (id_func, id_turno, dia_semana, ativo) VALUES (" + _admFunc + ", " + _admTurn + ", 'Todos', '1')";
            ObjBancoDados.ExecutaComando(comando);
        }
        
    }
}
