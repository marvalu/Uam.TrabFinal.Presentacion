﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uam.TrabFinal.Entidades
{
    public interface  ICRUD <T>
    {

        Boolean Insertar(T entidad);
        void Elminiar(int id);
        void Modificar(T entidad);
        DataTable Buscar(int id);
        DataTable BuscarTodos();
    }
}
