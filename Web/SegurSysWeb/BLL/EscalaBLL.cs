using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class EscalaBLL
    {
        EscalaDAL escalaDAL;

        public EscalaBLL()
        {
            this.escalaDAL = new EscalaDAL();
        }

        public string listarTabelaInicioHTML(Escala objEsc)
        {
            escalaDAL.find(objEsc);
            string linhas = "<td>" + objEsc.Horario_de_inicio.Substring(0,5) + "</td>";
            return linhas;
        }
        public string listarTabelaFimHTML(Escala objEsc)
        {
            escalaDAL.find(objEsc);
            string linhas = "<td>" + objEsc.Horario_de_termino.Substring(0, 5) + "</td>";
            return linhas;
        }

    }
}
