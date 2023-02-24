using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Alejandro.Data
{
    public class DValidarAcceso
    {
        public DataTable Validar_Acceso(string Usuario, string Contraseña)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                sqlConnection.ConnectionString = Conexión.Cn;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "Validar Acceso";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@Usuario", Usuario));
                sqlCommand.Parameters.Add(new SqlParameter("@Contraseña", Contraseña));

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
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