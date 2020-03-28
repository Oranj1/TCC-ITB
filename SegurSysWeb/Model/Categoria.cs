using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Categoria
    {
        //Atributos
        private int idCategoria;
        private string nomeCategoria;
        private string descrCategoria;
        private string statusCategoria;

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

        public string StatusCategoria
        {
            get
            {
                return statusCategoria;
            }

            set
            {
                statusCategoria = value;
            }
        }

        //Construtores
        public Categoria()
        {
        }

        public Categoria(int idCategoria, string nomeCategoria, string descrCategoria, string statusCategoria)
        {
            this.IdCategoria = idCategoria;
            this.NomeCategoria = nomeCategoria;
            this.DescrCategoria = descrCategoria;
            this.StatusCategoria = statusCategoria;
        }



    }
}
