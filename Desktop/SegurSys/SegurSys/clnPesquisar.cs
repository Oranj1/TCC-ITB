using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SegurSys
{
    class clnPesquisar
    {
        string comando;
        cldBancoDados ObjBancoDados = new cldBancoDados();

        public DataTable LocalizarPorNome(string nome)
        {
            comando = "select funcionario.id_func , funcionario.nome from funcionario where funcionario.nome like '%" + nome + "%' and  nivel_Acesso != '1' and  funcionario.ativo = '1' order by id_func";
            return ObjBancoDados.RetornaTabela(comando);
        }

        public DataTable Relatorios()
        {
            comando = "select id_relatorio, data, funcionario.nome from relatorio inner join funcionario on relatorio.id_func = funcionario.id_func";
            return ObjBancoDados.RetornaTabela(comando);
        }

        public DataTable LocalizarPorId(string id)
        {
            comando = "select funcionario.id_func , funcionario.nome from funcionario where funcionario.id_func like '%" + id + "%' and  nivel_Acesso != '1' and  funcionario.ativo = '1' order by id_func";
            return ObjBancoDados.RetornaTabela(comando);
        }

        public DataTable RelatorioPorId(string id_rel)
        {
            comando = "select id_relatorio, data, funcionario.nome from relatorio inner join funcionario on relatorio.id_func = funcionario.id_func where id_relatorio = '" + id_rel + "'";
            return ObjBancoDados.RetornaTabela(comando);
        }

        public DataTable PesquisarAtual()
        {
            comando = "select Atual.id_func, Funcionario.nome, Atual.trabalhando, Atual.intervalo, Atual.ponto_atual, Atual.proximo_ponto From Atual inner join Funcionario on Funcionario.id_func = Atual.id_func where trabalhando = 'Sim'";
            return ObjBancoDados.RetornaTabela(comando);
        }

        public SqlDataReader RelatorioPorIdLinha(string id_rel)
        {
            comando = "select data, funcionario.nome, relatorio_dia from relatorio inner join funcionario on relatorio.id_func = funcionario.id_func where id_relatorio = '" + id_rel + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }

        public DataTable LocalizarIdOcorrencia(string id)
        {
            comando = "select Ocorrencia.id_ocorrencia , Ocorrencia.hora_data_registro, Funcionario.nome, Ocorrencia.nivel_ocorrencia, Ocorrencia._status from ocorrencia inner join Funcionario on Ocorrencia.id_func = Funcionario.id_func where id_ocorrencia like '" + id + "' order by id_ocorrencia";
            return ObjBancoDados.RetornaTabela(comando);
        }
        public SqlDataReader LocalizarId(string id)
        {
            comando = "select * from funcionario where id_func = '" + id + "' and  nivel_Acesso != '1' and  ativo = '1'";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public SqlDataReader LocalizarUser(string user)
        {
            comando = "select funcionario.*, turno.* from funcionario inner join Escala on Funcionario.id_func = Escala.id_func inner join turno on Escala.id_turno = Turno.id_turno where Funcionario.usuario = '" + user + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }

        public SqlDataReader AchaDiaPorId(string id, string dia)
        {
            comando = "select turno.* from funcionario inner join Escala on Funcionario.id_func = Escala.id_func inner join turno on Escala.id_turno = Turno.id_turno where Funcionario.id_func = '" + id + "' and Funcionario.ativo = '1' and Funcionario.nivel_acesso != '1' and dia_semana = '" + dia + "' and Escala.ativo = '1'";
            return ObjBancoDados.RetornaLinha(comando);
        }

        public SqlDataReader PesquisarUsuarioExistente(string user, string cpf)
        {
            comando = "select usuario, cpf from Funcionario where usuario = '" + user + "' or cpf = '" + cpf + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }

        public SqlDataReader PontoExistente(string ponto)
        {
            comando = "select ponto from Area where ponto = '" + ponto + "' and ativo = '1'";
            return ObjBancoDados.RetornaLinha(comando);
        }

        public SqlDataReader PesquisarExisteAlterar(string user, string antigoUser)
        {
            comando = "select usuario from Funcionario where usuario = '" + user + "' and usuario != '" + antigoUser + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public SqlDataReader PesquisarExisteAlterarCpf(string cpf, string antigoCpf)
        {
            comando = "select cpf from Funcionario where cpf = '" + cpf + "' and cpf != '" + antigoCpf + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public SqlDataReader AchaFunc(string id)
        {
            comando = "select * from Funcionario where id = '" + id + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public SqlDataReader AchaTurnoPorID(string id)
        {
            comando = "select funcionario.*, turno.* from funcionario inner join Escala on Funcionario.id_func = Escala.id_func inner join turno on Escala.id_turno = Turno.id_turno where Funcionario.id_func = '" + id + "' and Funcionario.ativo = '1'";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public SqlDataReader UltimoRegistroInserido()
        {
            comando = "SELECT top 1 id_turno  from turno order by id_turno desc";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public SqlDataReader UltimoRegistroFunc()
        {
            comando = "SELECT top 1 id_func  from Funcionario order by id_func desc";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public SqlDataReader PesquisaDia(string id, string dia)
        {
            comando = "select * from escala where id_func = '" + id + "' and dia_semana = '" + dia + "' and ativo = 1";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public SqlDataReader AchaTurnoPorIdComDia(string id, string dia)
        {
            comando = "select funcionario.*, turno.* from funcionario inner join Escala on Funcionario.id_func = Escala.id_func inner join turno on Escala.id_turno = Turno.id_turno where Funcionario.id_func = '" + id + "' and Funcionario.ativo = '1' and Funcionario.nivel_acesso != '1' and Escala.dia_semana = '" + dia + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }

        public SqlDataReader IdArea(string nomeArea)
        {
            comando = "select id_area from area where ponto = '" + nomeArea + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }

        public SqlDataReader LocalizarNivelAcesso(string user)
        {
            comando = "select * from funcionario where usuario = '" + user + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public SqlDataReader AchaRotaPorEscala(string id_escala)
        {
            comando = "select Ronda.*, Escala.* from Ronda inner join Escala on Escala.id_escala = Ronda.id_escala where Ronda.id_escala = '" + id_escala + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public SqlDataReader AchaEscala(string id)
        {
            comando = "select * from escala where id_func = '" + id + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public SqlDataReader AchaRonda(string escala)
        {
            comando = "select * from ronda where id_escala = '" + escala + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public SqlDataReader PegaIdArea(string area)
        {
            comando = "select * from area where ponto = '" + area + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public SqlDataReader LocalizarUltimaOcorrencia()
        {
            comando = "select top 1 * from Ocorrencia Order By hora_data_registro desc";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public DataTable LocalizarIdOcorrenciaSemId()
        {
            comando = "select Ocorrencia.id_ocorrencia , Ocorrencia.hora_data_registro, Funcionario.nome, Ocorrencia.nivel_ocorrencia, Ocorrencia._status from ocorrencia inner join Funcionario on Ocorrencia.id_func = Funcionario.id_func order by id_ocorrencia desc";
            return ObjBancoDados.RetornaTabela(comando);
        }
        public SqlDataReader PesquisaOcorrencia(string id)
        {
            comando = "select Ocorrencia.*, Funcionario.nome, Area.ponto from Ocorrencia INNER JOIN Funcionario ON Ocorrencia.id_func = Funcionario.id_func INNER JOIN Area ON Ocorrencia.id_area = Area.id_area where id_ocorrencia = '" + id + "' order by id_ocorrencia desc";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public SqlDataReader VerFuncionariosNaoPreenchidos(string dia, int rowNum)
        {
            comando = "with func as(select top 9999 funcionario.*, ROW_NUMBER() OVER(ORDER BY Funcionario.id_func) as RowNum , Turno.* from funcionario inner join escala on Funcionario.id_func = escala.id_func inner join turno on Escala.id_turno = Turno.id_turno where Escala.dia_semana = '" + dia + "' and Funcionario.ativo = '1' and Funcionario.nivel_acesso = '2' order by id_func) select * from func where RowNum = " + rowNum;
            return ObjBancoDados.RetornaLinha(comando);
        }
        public DataTable LocalizarPorNomeComDia(string nome, string dia)
        {
            comando = "select distinct funcionario.id_func , funcionario.nome, Turno.periodo from funcionario left join escala on Funcionario.id_func = escala.id_func left join turno on Escala.id_turno = Turno.id_turno where funcionario.nome like '%" + nome + "%' and  nivel_Acesso != '1' and  funcionario.ativo = '1' and escala.dia_semana = '" + dia + "'  and escala.ativo = 1 order by id_func";
            return ObjBancoDados.RetornaTabela(comando);
        }
        public DataTable LocalizarPorIdComDia(string id, string dia)
        {
            comando = "select distinct funcionario.id_func , funcionario.nome, Turno.periodo from funcionario left join escala on Funcionario.id_func = escala.id_func left join turno on Escala.id_turno = Turno.id_turno where funcionario.id_func like '%" + id + "%' and  nivel_Acesso != '1' and  funcionario.ativo = '1' and escala.dia_semana = '" + dia + "' and escala.ativo = 1 order by id_func";
            return ObjBancoDados.RetornaTabela(comando);
        }
        public SqlDataReader TemAdmin()
        {
            comando = "select * from funcionario where nivel_acesso = 1";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public DataTable PreencherComboRonda()
        {
            comando = "select ponto from area where ativo = '1'";
            return ObjBancoDados.RetornaTabela(comando);
        }

        public SqlDataReader PreencherTodosPontos(string id)
        {
            comando = "select ponto from area where id_area = '" + id + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }

        public SqlDataReader PesquisarUserExiste(string usuario)
        {
            comando = "select usuario from Funcionario where usuario = '" + usuario + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public DataTable TrabalhamAgora(string dia)
        {
            comando = "select funcionario.id_func, funcionario.nome, Turno.horario_de_inicio, Turno.horario_intervalo, Turno.horario_termino_intervalo, Turno.horario_de_termino  from funcionario left join escala on Funcionario.id_func = escala.id_func left join turno on Escala.id_turno = Turno.id_turno where nivel_Acesso != '1' and  funcionario.ativo = '1' and escala.dia_semana = '" + dia + "'  and escala.ativo = 1 order by funcionario.id_func";
            return ObjBancoDados.RetornaTabela(comando);
        }
        public SqlDataReader PesquisarExisteAdm(string user)
        {
            comando = "select usuario from Funcionario where usuario = '" + user + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public SqlDataReader LocalizarIdPorNome(string nome) //não faça isso use apenas chave primaira :) ...
        {
            comando = "select id_func from Funcionario where nome = '" + nome + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public SqlDataReader IdDeQuemViu(string id)
        {
            comando = "select nome from funcionario where id_func = '" + id + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }
    }
}
