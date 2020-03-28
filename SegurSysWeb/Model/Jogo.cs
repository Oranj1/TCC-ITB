using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //adicionar o modificador de acesso public
    //para a classe ficar disponível em todo o
    //projeto
    public class Jogo
    {
        //Atributos
        private int idJogo;
        private string nomejogo;
        private string descrjogo;
        private string urlImagem;
        private double precojogo;
        private string statusjogo;
        private int idCategoria;
        private string nomeCategoria;
        private string descrCategoria;

        //Método(s) construtor
        public Jogo()
        {
        }

        public Jogo(int idJogo, string nomejogo, string descrjogo, string urlImagem, double precojogo, string statusjogo, int idCategoria, string nomeCategoria, string descrCategoria)
        {
            this.IdJogo = idJogo;
            this.Nomejogo = nomejogo;
            this.Descrjogo = descrjogo;
            this.UrlImagem = urlImagem;
            this.Precojogo = precojogo;
            this.Statusjogo = statusjogo;
            this.IdCategoria = idCategoria;
            this.NomeCategoria = nomeCategoria;
            this.DescrCategoria = descrCategoria;
        }

        //Métodos getters e setters
        public int IdJogo
        {
            get
            {
                return idJogo;
            }

            set
            {
                idJogo = value;
            }
        }

        public string Nomejogo
        {
            get
            {
                return nomejogo;
            }

            set
            {
                nomejogo = value;
            }
        }

        public string Descrjogo
        {
            get
            {
                return descrjogo;
            }

            set
            {
                descrjogo = value;
            }
        }

        public string UrlImagem
        {
            get
            {
                return urlImagem;
            }

            set
            {
                urlImagem = value;
            }
        }

        public double Precojogo
        {
            get
            {
                return precojogo;
            }

            set
            {
                precojogo = value;
            }
        }

        public string Statusjogo
        {
            get
            {
                return statusjogo;
            }

            set
            {
                statusjogo = value;
            }
        }

        public int IdCategoria
        {
            get
            {
                return idCategoria;
            }

            set
            {
                idCategoria = value;
            }
        }

        public string NomeCategoria
        {
            get
            {
                return nomeCategoria;
            }

            set
            {
                nomeCategoria = value;
            }
        }

        public string DescrCategoria
        {
            get
            {
                return descrCategoria;
            }

            set
            {
                descrCategoria = value;
            }
        }


    }
}
