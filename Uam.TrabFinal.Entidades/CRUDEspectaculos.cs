using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uam.TrabFinal.Datos;

namespace Uam.TrabFinal.Entidades
{
    public class CRUDEspectaculos : ICRUD<Espectaculo>
    {
        Conexion conexion = new Conexion();

        public DataTable Buscar(int id)
        {
            string query = string.Format("SELECT * FROM Espectaculos Where Id = {0};", id);

            return conexion.ConexionADO(query);
        }

        public DataTable BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Elminiar(int id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Espectaculo entidad)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Espectaculo entidad)
        {
            throw new NotImplementedException();
        }
    }
}
