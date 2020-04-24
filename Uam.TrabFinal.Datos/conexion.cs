using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Uam.TrabFinal.Datos
{
   public class conexion
    {

      private string ConnectionString = @"Data Source=DESKTOP-9I35C0O\SQLEXPRESS;Initial Catalog=TrabFinal;User ID=progra;Password=123456";
     //   private readonly string ConnectionString = "Data Source=.;Initial Catalog=Progra3;Integrated Security=True";
        public Boolean Query(string query)
        {
            SqlDataReader resultado = null;
            try
            {
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    cnn.Open();
                    SqlCommand cmd;
                    cmd = new SqlCommand(query, cnn);
                    resultado = cmd.ExecuteReader();
                    if (resultado.HasRows)
                    {
                        cmd.Dispose();
                        return false;
                    }
                    else
                    {
                        cmd.Dispose();
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("El error es :", ex.Message);
                return true;
            }

        }
        public Boolean NonQuery(string sqlQuery)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    cnn.Open();
                    SqlCommand cmd;
                    cmd = new SqlCommand(sqlQuery, cnn);
                    if (cmd.ExecuteNonQuery() != -1)
                    {
                        cmd.Dispose();
                        return true;
                    }
                    else
                    {
                        cmd.Dispose();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("El error es :", ex.Message);
                return false;
            }
        }

        public DataTable ConexionADO(string query)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, ConnectionString);
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
                return null;
            }
        }


    }
}
