using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uam.TrabFinal.Datos;

namespace Uam.TrabFinal.Entidades
{
    public class IOperacionesEspectaculo : ICRUD<Espectaculo>
    {
        conexion conexion = new conexion();

        public DataTable Buscar(int id)
        {
            string query = string.Format("SELECT * FROM Espectaculos Where Id = {0};", id);

            return conexion.ConexionADO(query);
        }

        public DataTable BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public bool Elminiar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(Espectaculo entidad)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Espectaculo entidad)
        {
            throw new NotImplementedException();
        }
    }
}
