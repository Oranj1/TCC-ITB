using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Web;

namespace BLL
{
    public class FuncionarioBLL
    {
        FuncionarioDAL funcDAL;
        Funcionario objFunc;


        public FuncionarioBLL()
        {
            this.funcDAL = new FuncionarioDAL();
            this.objFunc = new Funcionario();
        }

        public bool autenticar(Funcionario objFunc)
        {
            bool result = false;

            result = this.funcDAL.autenticarFuncionario(objFunc);
            //gavar dados na sessão caso result = true
            if(result)
            {
                HttpContext.Current.Session["usuarioLogado"] = (Funcionario) objFunc;

            }

            return result;
        }

        public void logout()
        {
            HttpContext.Current.Session["usuarioLogado"] = null;
        }


    }
}
