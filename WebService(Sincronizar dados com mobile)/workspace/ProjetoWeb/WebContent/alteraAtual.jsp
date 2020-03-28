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
	// Comando SQL, que ira realizar a Alteracao no banco de dados.
    String query =  "UPDATE Atual SET id_atual = '"+request.getParameter("id_atual");
    				if(request.getParameter("trabalhando").equals("Sim")){
    					query += "', trabalhando = '"+request.getParameter("trabalhando");
    				}else{
    					query += "', trabalhando = 'Não";
    				}if(request.getParameter("intervalo").equals("Sim")){
    					query += "', intervalo = '"+request.getParameter("intervalo");
    				}else{
    					query += "', intervalo = 'Não";
    				}
    				query += "', ponto_atual = '"+request.getParameter("ponto_atual")
    				+ "', proximo_ponto = '"+request.getParameter("proximo_ponto")
			        + "'  WHERE id_func = " + request.getParameter("id_func");
	
        try{
        	conexao.ponte.executeUpdate(query);
        }
        catch(Exception erro){
             System.err.print("Erro ao Gravar " + erro);
        }
%>