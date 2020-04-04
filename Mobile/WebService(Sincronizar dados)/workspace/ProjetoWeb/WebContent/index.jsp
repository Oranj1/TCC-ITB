<%@ page import="classeConexao.*"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1"> 
<title>Segursys</title>
</head>
<body>

	<center>
	
	<font face=verdana size=2>
		<a href="listagem.jsp">Listagem dos Funcionarios</a> 
	</font>
	<hr>
	<font face=verdana size=2>
		<%
			Conexao conexao = new Conexao();     
			out.println(conexao.getStatus());
		%>
	</font>
	<hr>
	
	</center>
	
</body>
</html>