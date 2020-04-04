using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Funcionario
    {

        private string id_func;
        private string nome;
        private string rg;
        private string cpf;
        private string usuario;
        private string senha;
        private string telefone;
        private string celular;
        private string nivel_acesso;
        private string ativo;

        public Funcionario()
        {

        }

        //Método(s) construtor
        public Funcionario(string id_func, string nome, string rg, string cpf, string usuario, string senha, string telefone, string celular, string nivel_acesso, string ativo)
        {
            this.Id_func = id_func;
            this.Nome = nome;
            this.Rg = rg;
            this.Cpf = cpf;
            this.Usuario = usuario;
            this.Senha = senha;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Nivel_acesso = nivel_acesso;
            this.Ativo = ativo;
        }

        //Métodos getters e setters
        public string Id_func { get => id_func; set => id_func = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Nivel_acesso { get => nivel_acesso; set => nivel_acesso = value; }
        public string Ativo { get => ativo; set => ativo = value; }
    }
}
