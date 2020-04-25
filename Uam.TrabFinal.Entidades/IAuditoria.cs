using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uam.TrabFinal.Entidades
{
    public interface IAuditoria<T>
    {
        //Interfaz para mostrar la tabla de auditoria
        DataTable buscarTodo();
        bool insertar(T item);
    }

}