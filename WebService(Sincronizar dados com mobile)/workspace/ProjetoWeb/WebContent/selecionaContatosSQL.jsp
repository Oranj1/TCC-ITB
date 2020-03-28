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
	String sql = "SELECT * FROM CADASTROWEB WHERE CODIGO=" + request.getParameter("codigo");
   	int registros = 0;
	try{
		ResultSet dados = conexao.ponte.executeQuery(sql);
           //(" EXECUTEI A SELECT, CARREGANDO INFORMACOES NA PAGINA...");
           while(dados.next())
               {
                   out.print(dados.getInt(1));
                   String Nome = dados.getString(2);
                   out.print("|"+Nome.replace(" ", "&"));
                   out.print("|"+dados.getString(3));
                   out.print("|"+dados.getString(4));
                   out.print("|"+dados.getString(5)+"?");
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