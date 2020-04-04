using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Turno
    {
        private string id_turno;
        private string horario_termino_intervalo;
        private string horario_intervalo;
        private string periodo;
        private string horario_de_inicio;
        private string horario_de_termino;

        public Turno()
        {

        }

        public Turno(string id_turno, string horario_termino_intervalo, string horario_intervalo, string periodo, string horario_de_inicio, string horario_de_termino)
        {
            this.Id_turno = id_turno;
            this.Horario_termino_intervalo = horario_termino_intervalo;
            this.Horario_intervalo = horario_intervalo;
            this.Periodo = periodo;
            this.Horario_de_inicio = horario_de_inicio;
            this.Horario_de_termino = horario_de_termino;
        }

        public string Id_turno { get => id_turno; set => id_turno = value; }
        public string Horario_termino_intervalo { get => horario_termino_intervalo; set => horario_termino_intervalo = value; }
        public string Horario_intervalo { get => horario_intervalo; set => horario_intervalo = value; }
        public string Periodo { get => periodo; set => periodo = value; }
        public string Horario_de_inicio { get => horario_de_inicio; set => horario_de_inicio = value; }
        public string Horario_de_termino { get => horario_de_termino; set => horario_de_termino = value; }
    }
}
