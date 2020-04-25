using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uam.TrabFinal.Datos;

namespace Uam.TrabFinal.Entidades
{
    public class IOperacionesAuditoria : IAuditoria<Clase_Auditoria>
    {
        conexion conexion = new conexion();
        public DataTable buscarTodo()
        {
            string query = string.Format("SELECT * FROM Auditoria;");

            return conexion.ConexionADO(query);
        }

        public bool insertar(Clase_Auditoria item)
        {
            string query = string.Format("INSERT INTO dbo.Auditoria (Id_cliente,Id_espectaculo,cant_Asientos,tipo_asiento,costo_Total)" + "VALUES ('{0}','{1}','{2}','{3}','{4}');",
            item.IdCliente, item.IdEvento, item.CantAsientos, item.Localidad, item.CostoTotal);
            return conexion.NonQuery(query);
        }
    }
}