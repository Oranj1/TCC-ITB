using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Relatorio
    {
        private string id_relatorio;
        private string data;
        private string relatorio_dia;
        private string id_func;


        public Relatorio()
        {

        }

        //Método(s) construtor
        public Relatorio(string id_relatorio, string data, string relatorio_dia, string id_func)
        {
            this.Id_relatorio = id_relatorio;
            this.Data = data;
            this.Relatorio_dia = relatorio_dia;
            this.Id_func = id_func;
        }

        //Métodos getters e setters
        public string Id_relatorio { get => id_relatorio; set => id_relatorio = value; }
        public string Data { get => data; set => data = value; }
        public string Relatorio_dia { get => relatorio_dia; set => relatorio_dia = value; }
        public string Id_func { get => id_func; set => id_func = value; }
    }
}
