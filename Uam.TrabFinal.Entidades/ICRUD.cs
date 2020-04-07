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

        void Insertar(T item);

        void Eliminar(T item);

        void Modificar(T item);
    }
}
