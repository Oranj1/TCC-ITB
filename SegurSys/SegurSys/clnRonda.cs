using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurSys
{
    class clnRonda
    {
        string comando;
        cldBancoDados ObjBancoDados = new cldBancoDados();
        clnPesquisar ObjClnPesquisar = new clnPesquisar();

        private string _caminho, _escala, _func, _ponto, _antigoPonto,_tempo;

        public string Caminho { get => _caminho; set => _caminho = value; }
        public string Escala { get => _escala; set => _escala = value; }
        public string Func { get => _func; set => _func = value; }
        public string Ponto { get => _ponto; set => _ponto = value; }
        public string AntigoPonto { get => _antigoPonto; set => _antigoPonto = value; }
        public string Tempo { get => _tempo; set => _tempo = value; }


        public void NovaRonda()
        {
            comando = "insert into Ronda(rota, tempo, id_escala) values(";
            comando += "'" + _caminho + "',";
            comando += "'" + _tempo + "',";
            comando += "'" + _escala + "')";
            ObjBancoDados.ExecutaComando(comando);
        }
        public void AlterarRonda()
        {
            comando = "update Ronda set rota = ";
            comando += "'" + _caminho + "',";
            comando += "tempo = '" + _tempo + "'";
            comando += "where id_escala = '" + _escala + "'";
            ObjBancoDados.ExecutaComando(comando);
        }
        public void NovoPonto()
        {
            comando = "insert into Area(ponto, ativo) VALUES (";
            comando += "'" + _ponto + "', '1')";
            ObjBancoDados.ExecutaComando(comando);
        }
        public void AlterarPonto()
        {
            comando = "update Area set ponto = ";
            comando += "'" + _ponto + "' ";
            comando += "where ponto = '" + _antigoPonto + "'";
            ObjBancoDados.ExecutaComando(comando);
            AlterarRondaPorPonto();
        }

        public void ExcluirPonto()
        {
            comando = "update Area set ativo = ";
            comando += "'0' where ponto = '" + _ponto + "'";
            ObjBancoDados.ExecutaComando(comando);
            ExcluirPontoNaRonda();
        }

        public void AlterarRondaPorPonto()
        {
            comando = "UPDATE Ronda set rota = REPLACE(rota, '";
            comando += _antigoPonto + "','" + _ponto + "')";
            ObjBancoDados.ExecutaComando(comando);
        }
        public void ExcluirPontoNaRonda()
        {
            comando = "UPDATE Ronda set rota = REPLACE(rota, '";
            comando += _ponto + "_','')";
            ObjBancoDados.ExecutaComando(comando);
        }
       
    }
}
