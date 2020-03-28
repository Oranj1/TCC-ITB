<%--
    Document   : Seleciona Registros
    Created on : 10/03/2015, 17:35:37
    Author     : Alberti
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@ page import="classeConexao.*"%>
<%@ page import="java.sql.*"%>
<%
	//(" ESTOU NA PAGINA JSP - CONECTANDO NO BANCO E EXECUTANDO A SELECT...");
	Conexao conexao = new Conexao();
	String sql = "SELECT id_area, ponto, ativo FROM AREA";
   	int registros = 0;
	try{
		ResultSet dados = conexao.ponte.executeQuery(sql);
           //(" EXECUTEI A SELECT, CARREGANDO INFORMACOES NA PAGINA...");
           while(dados.next())
               {
                   out.print(dados.getString(1)); //id
                   out.print("|"+dados.getString(2)); //ponto
                   out.print("|"+dados.getString(3)+"?"); //ativo
                   registros++;
               }
   	    dados.close();
   		} 
	catch(Exception e)
   		{
   			out.println(e.getMessage());
   		}
	//(" INFORMANDO A QUANTIDADE DE REGISTROS INSERIDOS NA PAGINA... ")".
	out.print("#{" + registros + "}" );
    //(" TERMINEI DE CARREGAR AS INFORMACOES NA PAGINA...");
%>