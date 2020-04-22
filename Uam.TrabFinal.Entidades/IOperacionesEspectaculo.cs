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
            string query = string.Format("SELECT * FROM Espectaculos;");

            return conexion.ConexionADO(query);
        }

        public void Elminiar(int entidad)
        {
            string query = string.Format("Delete dbo.Espectaculos WHERE Id= {0};", entidad.Id);
            conexion.NonQuery(query);
        }

        public void Insertar(Espectaculo entidad)
        {
            // string query = string.Format("INSERT INTO dbo.Espectaculo (Nombre,Descripcion,Horario) " + "VALUES('{0}','{1}','{2}');", entidad.Nombre, entidad.Descripcion, entidad.Horario);

            string query = string.Format("INSERT INTO dbo.Espectaculos (Grupo,Descripcion,CantidadAsientosBajos,CantidadAsientosMedios,CantidadAsientosAltos,CostoAsientosAltos,CostoAsientosMedio,CostoAsientosBajos,CantidadAsientosDiscapacitados,CostoAsientosDiscapacitados)" + "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',('{6}','{7}','{8}','{9}');",
                entidad.Grupo, entidad.Descripcion, entidad.CantidadAsientosBajos, entidad.CantidadAsientosMedios, entidad.CantidadAsientosAltos, entidad.CostoAsientosAltos, entidad.CostoAsientosMedios, entidad.CostoAsientosBajos, entidad.CantidadAsientosDiscapacitados, entidad.CostoAsientosDiscapacitados);




            conexion.NonQuery(query);
        }

        public void Modificar(Espectaculo entidad)
        {
            //string query = string.Format("UPDATE dbo.Espectaculo SET Nombre='{0}',Descripcion='{1}',Horario='{2}' WHERE IdMenu= '{3}'; ", entidad.Nombre, entidad.Descripcion, entidad.Horario, entidad.ID);

            string query = string.Format("UPDATE dbo.Espectaculo SET Grupo='{0},Descripcion='{1},CantidadAsientosBajos='{2},CantidadAsientosMedios='{3},CantidadAsientosAltos='{4},CostoAsientosAltos='{5},CostoAsientosMedio='{6},CostoAsientosBajos='{7},CantidadAsientosDiscapacitados='{8},CostoAsientosDiscapacitados='{9}, WHERE Id= '{3}'; ",
                 entidad.Grupo, entidad.Descripcion, entidad.CantidadAsientosBajos, entidad.CantidadAsientosMedios, entidad.CantidadAsientosAltos, entidad.CostoAsientosAltos, entidad.CostoAsientosMedios, entidad.CostoAsientosBajos, entidad.CantidadAsientosDiscapacitados, entidad.CostoAsientosDiscapacitados);


            //           UPDATE[dbo].[Espectaculos]
            //  SET[Grupo] = < Grupo, nchar(100),>
            //     ,[Descripcion] = <Descripcion, nchar(100),>
            //     ,[CantidadAsientosBajos] = <CantidadAsientosBajos, int,>
            //     ,[CantidadAsientosMedios] = <CantidadAsientosMedios, int,>
            //     ,[CantidadAsientosAltos] = <CantidadAsientosAltos, int,>
            //     ,[CostoAsientosAltos] = <CostoAsientosAltos, int,>
            //     ,[CostoAsientosMedio] = <CostoAsientosMedio, int,>
            //     ,[CostoAsientosBajos] = <CostoAsientosBajos, int,>
            //     ,[CantidadAsientosDiscapacitados] = <CantidadAsientosDiscapacitados, int,>
            //     ,[CostoAsientosDiscapacitados] = <CostoAsientosDiscapacitados, int,>
            //WHERE<Search Conditions,,>

            conexion.NonQuery(query);
        }
    }
}
