package classeConexao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Statement;
import oracle.jdbc.pool.OracleDataSource;

public class Conexao 
{
	private String URL     = "jdbc:jtds:sqlserver://localhost:1433/BD_Agenda;";   
	private String DRIVER  = "net.sourceforge.jtds.jdbc.Driver";
	private String USUARIO = "sa";
	private String SENHA   = "123456";
	private String BANCO   = "SQL";
	
	public void SelectBD(String Banco)
	{
		BANCO = Banco;
		if (BANCO.equals("SQL"))
		{	
			//CONEXAO SQL EXPRESS 
			URL     = "jdbc:jtds:sqlserver://localhost:1433/Segursys;";
			DRIVER  = "net.sourceforge.jtds.jdbc.Driver";
			USUARIO = "sa";
			SENHA   = "123456";
		}
		else if(BANCO.equals("ORACLE"))
		{
			//CONEXAO ORACLE EXPRESS
			URL     = "jdbc:oracle:thin:@localhost:1521:xe";
			DRIVER  = "oracle.jdbc.driver.OracleDriver";
			USUARIO = "android"; //"sys as sysdba";
			SENHA   = "123456";
		}
	}
	public Statement ponte;
	public String status = "";
	public String getStatus() 
	{
		return status;
	}

		public Conexao()
	{
		try {
			System.out.println("Banco "+ BANCO);
			SelectBD(BANCO);
			if (BANCO.equals("SQL"))
			{	
				Class.forName(DRIVER);
				Connection con;
				con = DriverManager.getConnection(URL,USUARIO,SENHA);
		        ponte = con.createStatement();
			}
			else if(BANCO.equals("ORACLE"))
			{
				Class.forName(DRIVER);
				Connection con;
				OracleDataSource ds;
		        ds = new OracleDataSource();
		        ds.setURL(URL);
		        con = ds.getConnection(USUARIO,SENHA);
				ponte = con.createStatement();
			}
			status = "Conectado no banco " + BANCO + "!!!" ;
		} catch (Exception e) {
			status = e.getMessage();
			e.printStackTrace();
		}
	}

	public void manutencao(String sql)
	{
		try {
			ponte.executeUpdate(sql);
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}
