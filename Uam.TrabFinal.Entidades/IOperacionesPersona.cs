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
            string query = string.Format("SELECT * FROM Persona Where Id = {0};", id);

            return conexion.ConexionADO(query);
        }

        public DataTable BuscarTodos()
        {
            string query = string.Format("SELECT * FROM Persona;");

            return conexion.ConexionADO(query);
        }

        public void Elminiar(int id)
        {
            string query = string.Format("Delete dbo.Persona WHERE Id= {0};", id);
            conexion.NonQuery(query);
        }

        public void Insertar(Persona entidad)
        {
            string query = string.Format("INSERT INTO dbo.Persona  (Nombre,Apellidos,Cedula,Email)" + "VALUES ('{0}','{1}','{2}','{3}');",
                entidad.Nombre, entidad.Apellido, entidad.Cedula, entidad.Email);


            //string query = string.Format("INSERT INTO dbo.Persona  (Nombre,Apellidos,Cedula,Email,Tipo,Password)" + "VALUES ('{0} ",
            //    entidad.Nombre, entidad.Apellido, entidad.Cedula, entidad.Email, entidad.TipoUsuario, entidad.Password, entidad.Id);

        }

        public void Modificar(Persona entidad)
        {
            string query = string.Format("UPDATE dbo.Persona SET Nombre='{0},Apellidos='{1},Cedula='{2},Email='{3},Tipo='{4},Password='{5}, WHERE Id= '{6}'; ",
                entidad.Nombre, entidad.Apellido, entidad.Cedula, entidad.Email, entidad.TipoUsuario, entidad.Password, entidad.Id);

        }
    }
}