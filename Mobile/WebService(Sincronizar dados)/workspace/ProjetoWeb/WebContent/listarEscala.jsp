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
	String sql = "select escala.id_escala, horario_de_inicio, horario_de_termino, dia_semana, escala.id_func, escala.ativo"
			+ " from turno inner join escala on Escala.id_turno = Turno.id_turno where dia_semana <> 'Todos'";
	int registros = 0;
	try {
		ResultSet dados = conexao.ponte.executeQuery(sql);
		//(" EXECUTEI A SELECT, CARREGANDO INFORMACOES NA PAGINA...");
		while (dados.next()) {
			out.print(dados.getString(1)); //id
			out.print("|" + dados.getString(2).substring(0,5)); //inicio
			out.print("|" + dados.getString(3).substring(0,5)); //fim
			out.print("|" + dados.getString(4)); //dia
			out.print("|" + dados.getString(5)); //id_func
			out.print("|" + dados.getString(6) + "?"); //ativo
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