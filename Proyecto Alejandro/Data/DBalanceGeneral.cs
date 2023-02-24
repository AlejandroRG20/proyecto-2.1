using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Alejandro.Data
{
    public class DBalanceGeneral
    {
        public DataTable BalanceGeneral()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter;
            try
            {
                sqlDataAdapter = new SqlDataAdapter("Select * from BalanceGeneral", Conexión.Cn);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            return dt;
        }
    }
}