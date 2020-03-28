using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Escala
    {
        //Atributos
        private string id_escala;
        private string id_func;
        private string id_turno;
        private string dia_semana;
        private string ativo;
        private string horario_termino_intervalo;
        private string horario_intervalo;
        private string periodo;
        private string horario_de_inicio;
        private string horario_de_termino;


        public Escala()
        {

        }

        public Escala(string id_escala, string id_func, string id_turno, string dia_semana, string ativo, string horario_termino_intervalo, string horario_intervalo, string periodo, string horario_de_inicio, string horario_de_termino)
        {
            this.Id_escala = id_escala;
            this.Id_func = id_func;
            this.Id_turno = id_turno;
            this.Dia_semana = dia_semana;
            this.Ativo = ativo;
            this.Horario_termino_intervalo = horario_termino_intervalo;
            this.Horario_intervalo = horario_intervalo;
            this.Periodo = periodo;
            this.Horario_de_inicio = horario_de_inicio;
            this.Horario_de_termino = horario_de_termino;
        }

        public string Id_escala { get => id_escala; set => id_escala = value; }
        public string Id_func { get => id_func; set => id_func = value; }
        public string Id_turno { get => id_turno; set => id_turno = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Ativo { get => ativo; set => ativo = value; }
        public string Horario_termino_intervalo { get => horario_termino_intervalo; set => horario_termino_intervalo = value; }
        public string Horario_intervalo { get => horario_intervalo; set => horario_intervalo = value; }
        public string Periodo { get => periodo; set => periodo = value; }
        public string Horario_de_inicio { get => horario_de_inicio; set => horario_de_inicio = value; }
        public string Horario_de_termino { get => horario_de_termino; set => horario_de_termino = value; }
    }
}
