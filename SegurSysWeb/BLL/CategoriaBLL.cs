using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriaBLL
    {
        //criar um atributo do tipo CategoriaDAL
        CategoriaDAL categoriaDAL;

        //método construtor inicializar o objeto categoriaDAL
        public CategoriaBLL()
        {
            this.categoriaDAL = new CategoriaDAL();
        }


        //Métodos de validação
        public string validarDados(Categoria obj)
        {
            string msg = null;
            //validações

            //Nome >= 3 e <= 80 //length 
            // deve retornar V caso não atenda a regra
  
            if (!(obj.NomeCategoria.Length > 1))
            {
                msg += "N";
            }


            //Descrição >= 15 e <= 200 //length 
            // deve retornar V caso não atenda a regra
            if (obj.DescrCategoria.Length < 15 || obj.DescrCategoria.Length > 200)
            {
                msg += "D";
            }

            //STATUS Deve ser "A" ou "I"  - Ativo ou Inativo
            // deve retornar V caso não atenda a regra
            if (obj.StatusCategoria != "A" && obj.StatusCategoria != "I")
            {
                msg += "S";
            }


            return msg;

        }


        //Métodos para manipulação 
        public string adicionar(Categoria obj)
        {
            string situacao = null;
            // validar 
            situacao = this.validarDados(obj);
            //testar validação
            if (String.IsNullOrEmpty(situacao))
            {
                try
                {
                    this.categoriaDAL.abrirConexao();
                    this.categoriaDAL.create(obj);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return situacao;
        }

        public string alterar(Categoria obj)
        {
            string situacao = null;
            // validar 
            situacao = this.validarDados(obj);
            //testar validação
            if (String.IsNullOrEmpty(situacao))
            {
                try
                {
                    this.categoriaDAL.abrirConexao();
                    this.categoriaDAL.update(obj);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            return situacao;
        }

        public string excluir(Categoria obj)
        {
            string situcao = null;
            //verifiar se o funcionari existe

            if (categoriaDAL.find(obj))
            {
                categoriaDAL.delete(obj);
            }
            else
            {
                situcao = "Categoria não existe!";
            }

            return situcao;

        }

        public string listarTabelaHTML()
        {
            string linhas = null;
            try
            {
                List<Categoria> lista = categoriaDAL.findAll();
                if (lista.Count == 0)
                {
                    linhas = "<tr><td colspan='4'>Não existem categorias cadastradas</td></tr>";
                }
                else
                {
                    foreach (Categoria objCat in lista)
                    {
                        linhas += "<tr>";
                        linhas += "<td>" + objCat.IdCategoria + "</td>";
                        linhas += "<td>" + objCat.NomeCategoria + "</td>";
                        linhas += "<td>" + objCat.DescrCategoria + "</td>";
                        linhas += "<td>" + objCat.StatusCategoria + "</td>";
                        linhas += "<td><a href='alterarCategoria.cshtml?id="+objCat.IdCategoria +
                                                "' ><img src='/recursos/img/editar.jpg'></a></td>";
                        linhas += "<td><a href='excluirCategoria.cshtml?id=" + objCat.IdCategoria +
                                            "' ><img src='/recursos/img/excluir.jpg'></a></td>";
                        linhas += "</tr>";
                    }
                }
            }
            catch (Exception ex)
            {
                linhas = "<tr><td colspan ='6'>" + ex.Message + "</td></tr>";
            }
            return linhas;
        }

    }
}
