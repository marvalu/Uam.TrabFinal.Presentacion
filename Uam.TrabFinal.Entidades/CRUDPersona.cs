using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uam.TrabFinal.Entidades
{
    public class CRUDPersona : ICRUD<Persona>
    {
        public Persona Buscar(int id)
        {
            throw new NotImplementedException();
        }

        Boolean Eliminar(Persona item)
        {
            string query = string.Format("SELECT * FROM Persona WHERE Id = {0};",item.Id);
            return dat.NonQuery(query);
             if (query!=null){
            string query = string.Format("DELETE Persona WHERE Id = {0};", item.Id);
                }
            return dat.NonQuery(query);
        }

        Boolean Insertar(Persona item)
        {
            string query = string.Format("SELECT * FROM Persona WHERE Email = {0};",item.Email);
                return dat.NonQuery(query);
            if (query==null){
              string query = string.Format("INSERT INTO Persona (Nombre,Apellidos,Cedula,Email,Tipo,Password) " +
                "VALUES('{0}','{1}','{2}','{3}','{4}','{5}');",
                item.Nombre, item.Apellido, item.Cedula, item.Email, item.TipoUsuario, item.Password);
                return dat.NonQuery(query);
                }
            else{
            Console.WriteLine("No se puede insertar mail igual");
                Boolean validar=false;
                return validar;
            }
            
        }

        Boolean Modificar(Persona item)
        {
             string query = string.Format("SELECT * FROM Persona WHERE Id = {0};",item.Id);
                return dat.NonQuery(query);
            if (query!=null){
                string query = string.Format("UPDATE INTO Persona (Nombre,Apellidos,Cedula,Email,Tipo,Password) " +
                "VALUES('{0}','{1}','{2}','{3}','{4}','{5}');",
                item.Nombre, item.Apellido, item.Cedula, item.Email, item.TipoUsuario, item.Password);
                return dat.NonQuery(query);


        }
    }
}
}