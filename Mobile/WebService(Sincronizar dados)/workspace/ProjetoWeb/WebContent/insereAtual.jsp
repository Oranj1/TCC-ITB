<%--
    Document   : Seleciona Registros
    Created on : 13/03/2015, 13:05:02
    Author     : Alberti
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@ page import="classeConexao.*"%>
<%@ page import="java.sql.*"%>
<%
   	Conexao conexao = new Conexao();
   	int registros = 0;
	// Comando SQL, que ira realizar o Insert no banco de dados.
    String query =	"INSERT INTO Atual (id_atual, trabalhando, intervalo, ponto_atual, proximo_ponto, id_func) " + 
    				"VALUES ('" + 
   					request.getParameter("id_atual") + "','";
    				if(!request.getParameter("trabalhando").equals("Sim")){
   						query += "Não','";
    				}else{
    					query += request.getParameter("trabalhando") + "','";
    				}
    				if(request.getParameter("intervalo").equals("Sim")){
   						query += request.getParameter("intervalo") + "','";
    				}else{
    					query += "Não','";
    				}
   		   			query += request.getParameter("ponto_atual") + "','" +
   	   		   		request.getParameter("proximo_ponto") + "','" +
   					request.getParameter("id_func") + "')";
        try{
        	//Executando o comando (query) SQL.
        	out.println(query);
        	conexao.ponte.executeUpdate(query);
        }
        catch(Exception erro){
             System.err.print("Erro ao Gravar "+erro);
        }
%>