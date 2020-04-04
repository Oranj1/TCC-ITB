using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;
using System.Threading.Tasks;

namespace BLL
{
    public class RelatorioBLL
    {
        //criar um atributo do tipo RelatorioDAL
        RelatorioDAL relatorioDal;
        

        //método construtor inicializar o objeto relatorioDAL
        public RelatorioBLL()
        {
            this.relatorioDal = new RelatorioDAL();
        }
        public string validarDados(Relatorio obj)
        {
            string msg = null;
 

            if (!(obj.Id_func.Length > 0))
            {
                msg += "I";
            }
            if (!(obj.Relatorio_dia.Length > 0))
            {
                msg += "R";
            }
            if (!(obj.Data.Length == 10))
            {
                msg += "D";
            }
            return msg;
        }
        public string adicionar(Relatorio Rel)
        {
            string situacao = null;

            situacao = this.validarDados(Rel);

            if (String.IsNullOrEmpty(situacao))
            {
                try
                {
                    this.relatorioDal.abrirConexao();
                    this.relatorioDal.create(Rel);
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            return situacao;

        }
    }
}
