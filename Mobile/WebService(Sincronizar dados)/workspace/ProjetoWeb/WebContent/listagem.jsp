<%@ page language="java" contentType="text/html; charset=ISO-8859-1" pageEncoding="ISO-8859-1"%>
<%@ page import="classeConexao.*,java.sql.*"%>
    
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>AULA DE TEEM - Integrando soluções!</title>
</head>
<body>
	<center>
	<font face=verdana size=3><b>
		AULA DE TEEM - Integrando soluções!
	</b></font>
	<hr>
	<font face=verdana size=2>
	<a href="index.jsp">Menu do Sistema</a>
	<hr>
	<font face=verdana size=2>
	<%
		try
		{	
		Conexao conexao = new Conexao();
	    String sql = "select * from Funcionario order by id_func";
	    
	    ResultSet dados = conexao.ponte.executeQuery(sql);
	    while(dados.next())
	    {
	    	out.println("codigo: <b>" + dados.getString("id_func") + "</b>");
	    	out.println(dados.getString("Nome"));
	    	out.println(dados.getString("usuario"));
	    	out.println(dados.getString("senha"));
	    	out.println(dados.getString("ativo"));
	    	out.println("<hr>");
	    }
	    
	    dados.close();
		} catch(Exception e)
		{
			out.println(e.getMessage());
		}
	%>
	</font>
<a href="index.jsp">RETORNAR AO MENU PRINCIPAL</a>
</body>
</html>