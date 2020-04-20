using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uam.TrabFinal.Datos;

namespace Uam.TrabFinal.Entidades
{
    public class OperacionesLogin
    {
        conexion cnn = new conexion();
        private readonly string ConnectionString = "Data Source=.;Initial Catalog=Progra3;Integrated Security=True";

      
            public Boolean Ingreso(Usuario usr)
            {

                string query = string.Format("select * from [dbo].[Admin]");

                try
                {
                    List<Usuario> respuesta;

                    respuesta = QueryUsingLista2(query);

                    if (respuesta != null)
                    {

                        foreach (Usuario user in respuesta)
                        {

                            if (user.Usr== user.Usr &&  user.Password == user.Password)
                            {

                                return true;

                            }
                            else
                            {

                                Interaction.MsgBox("Usuario o password incorrecto \n Verifique datos", 0, "Advertencia");
                                return false;

                            }

                        }

                    }
                   

                }
                catch (Exception ex)
                {

                    Interaction.MsgBox("operacionesUsuario.login Error: " + ex.Message, 0, "Advertencia");


                }

                return false;
            }


        public List<Usuario> QueryUsingLista2(string query)
        {

            List<Usuario> usr = new List<Usuario>();
            SqlCommand cmd;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                try
                {
                    connection.Open();
                    cmd = new SqlCommand(query, connection);
                    SqlDataReader resultado = cmd.ExecuteReader();
                    cmd.Dispose();
                    if (resultado.HasRows)
                    {
                        while (resultado.Read())
                        {

                            usr.Add(new Usuario(resultado.GetString(0).Trim(), resultado.GetString(1).Trim()));

                        }

                        return usr;
                    }

                }
                catch (Exception ex)
                {

                    Interaction.MsgBox("Conexion.QueryUsingLista2 Error: " + ex.Message, 0, "Advertencia");
                    return null;
                }
            }
            return null;
        }
    }
}

