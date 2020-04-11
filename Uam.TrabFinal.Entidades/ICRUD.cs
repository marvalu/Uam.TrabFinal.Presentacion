using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uam.TrabFinal.Entidades
{
    public interface  ICRUD <T>
    {


        T Buscar(int id);

        Boolean Insertar(T item);

        Boolean Eliminar(T item);

        Boolean Modificar(T item);
    }
}
