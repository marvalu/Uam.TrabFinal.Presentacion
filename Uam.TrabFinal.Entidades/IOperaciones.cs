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

        void Insertar(T entidad);
        void Elminiar(T entidad);
        void Modificar(T entidad);
        DataTable Buscar(int id);
        DataTable BuscarTodos();
    }
}
