<%--
    Document   : Seleciona Registros
    Created on : 13/03/2015, 13:05:02
    Author     : Alberti
--%>

<%@page contentType="text/html" pageEncoding="utf-8"%>
<%@ page import="classeConexao.*"%>
<%@ page import="java.sql.*"%>
<%
   	Conexao conexao = new Conexao();
   	int registros = 0;
	// Comando SQL, que ira realizar o Insert no banco de dados.
    String query =	"INSERT INTO Ocorrencia (acontecimento, hora_data_registro, _status, nivel_ocorrencia," + 
    		" data_acontecimento, hora_do_termino, hora_de_inicio, id_area, id_func) " + 
    				"VALUES ('";
    				if(!request.getParameter("acontecimento").equals("InvasÃ£o"))
   						query += request.getParameter("acontecimento") + "','";
    				else{
    					query += "Invasão','";
    				}
   					query += request.getParameter("hora_data_registro") + "','" +
   					request.getParameter("_status") + "','";
   					if(request.getParameter("nivel_ocorrencia").equals("Alto") || request.getParameter("nivel_ocorrencia").equals("Baixo")){
   		   				query += request.getParameter("nivel_ocorrencia") + "','";
   					}else{
   						query += "Médio','";
   					}
   		   			query += request.getParameter("data_acontecimento") + "',";
   		   			if(request.getParameter("hora_do_termino").equals("null")){
   	   					query += request.getParameter("hora_do_termino") + ",'"; 
   		   			}else{
   		   				query += "'" + request.getParameter("hora_do_termino") + "','";
   		   			}
   	   				query += request.getParameter("hora_de_inicio") + "','" +
   	   		   		request.getParameter("id_area") + "','" +
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