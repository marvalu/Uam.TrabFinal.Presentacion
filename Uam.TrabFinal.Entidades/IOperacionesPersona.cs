using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uam.TrabFinal.Datos;

namespace Uam.TrabFinal.Entidades
{
    public class IOperacionesPersona : ICRUD<Persona>
    {
        conexion conexion = new conexion();
        public DataTable Buscar(int id)
        {
            string query = string.Format("SELECT * FROM Usuarios Where Id = {0};", id);

            return conexion.ConexionADO(query);
        }

        public DataTable BuscarTodos()
        {
            string query = string.Format("SELECT * FROM Usuarios;");

            return conexion.ConexionADO(query);
        }

        public void Elminiar(int id)
        {
            string query = string.Format("Delete dbo.Usuarios WHERE Id= {0};", id);
            conexion.NonQuery(query);
        }

        public bool Insertar(Persona entidad)
        {
            string query = string.Format("INSERT INTO dbo.Usuarios (Nombre,Apellidos,Cedula,Email,TipoUsuario,Password)" + "VALUES ('{0}','{1}','{2}','{3},'{4}','{5}');",
                entidad.Nombre, entidad.Apellido, entidad.Cedula, entidad.Email,entidad.TipoUsuario, entidad.Password);
          return  conexion.NonQuery(query);


            //string query = string.Format("INSERT INTO dbo.Persona  (Nombre,Apellidos,Cedula,Email,Tipo,Password)" + "VALUES ('{0} ",
            //    entidad.Nombre, entidad.Apellido, entidad.Cedula, entidad.Email, entidad.TipoUsuario, entidad.Password, entidad.Id);

        }

        public void Modificar(Persona entidad)
        {
            string query = string.Format("UPDATE dbo.Usuarios SET Nombre='{0},Apellidos='{1},Cedula='{2},Email='{3},Tipo='{4},Password='{5}, WHERE Id= '{6}'; ",
                entidad.Nombre, entidad.Apellido, entidad.Cedula, entidad.Email, entidad.TipoUsuario, entidad.Password, entidad.Id);

        }
    }
}