<%--
    Document   : Seleciona Registros
    Created on : 27/03/2015, 00:31:12
    Author     : Alberti
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@ page import="classeConexao.*"%>
<%@ page import="java.sql.*"%>

<%
   	Conexao conexao = new Conexao();
   	int registros = 0;

    String query =  "DELETE FROM Atual WHERE id_func = '" + request.getParameter("id_func") + "'";
    
    try{
    	conexao.ponte.executeUpdate(query);
    }
    catch(Exception erro){
         System.err.print("Erro ao Gravar " + erro);
    }
%>