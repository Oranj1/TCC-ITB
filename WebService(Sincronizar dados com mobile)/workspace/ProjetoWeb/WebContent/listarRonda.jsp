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
	String sql = "select id_ronda, rota, id_escala, tempo from ronda";
	int registros = 0;
	try {
		ResultSet dados = conexao.ponte.executeQuery(sql);
		//(" EXECUTEI A SELECT, CARREGANDO INFORMACOES NA PAGINA...");
		while (dados.next()) {
			out.print(dados.getString(1)); //id
			out.print("|" + dados.getString(2)); //rota
			out.print("|" + dados.getString(3)); //id_escala
			out.print("|1"); //ativo
			out.print("|" + dados.getString(4).substring(0,5) + "?"); //tempo
			registros++;
		}
		dados.close();
	} catch (Exception e) {
		out.println(e.getMessage());
	}
	//(" INFORMANDO A QUANTIDADE DE REGISTROS INSERIDOS NA PAGINA... ")".
	out.print("#{" + registros + "}");
	//(" TERMINEI DE CARREGAR AS INFORMACOES NA PAGINA...");
%>