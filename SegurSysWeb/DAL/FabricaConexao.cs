using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FabricaConexao
    {

        private static SqlConnection cn ;

        private static string stringConexao = @"Server=DESKTOP-2ITDEA2\SQLEX;
            Database=Segursys;User Id= sa; Password=123456";
    

        public static SqlConnection getConexao()
        {
            try
            {
                cn = new SqlConnection(stringConexao);
                return cn;

            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

    }
}
