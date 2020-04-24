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
            string query = string.Format("SELECT CantidadAsientosBajos,CantidadAsientosMedios,CantidadAsientosAltos," +
                "CostoAsientosAltos,CostoAsientosMedio,CostoAsientosBajos," +
                "CantidadAsientosDiscapacitados,CostoAsientosDiscapacitados FROM Espectaculos Where Id = {0};", id);

            return conexion.ConexionADO(query);
        }

        public DataTable BuscarTodos()
        {
            string query = string.Format("SELECT * FROM Espectaculos;");

            return conexion.ConexionADO(query);
        }

        public void Elminiar(int entidad)
        {
            string query = string.Format("Delete dbo.Espectaculos WHERE Id= {0};",entidad);
            conexion.NonQuery(query);
        }

        public bool Insertar(Espectaculo entidad)
        {
            // string query = string.Format("INSERT INTO dbo.Espectaculo (Nombre,Descripcion,Horario) " + "VALUES('{0}','{1}','{2}');", entidad.Nombre, entidad.Descripcion, entidad.Horario);

            string query = string.Format("INSERT INTO dbo.Espectaculos (Grupo,Descripcion,CantidadAsientosBajos,CantidadAsientosMedios,CantidadAsientosAltos,CostoAsientosAltos,CostoAsientosMedio,CostoAsientosBajos,CantidadAsientosDiscapacitados,CostoAsientosDiscapacitados)" + "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',('{6}','{7}','{8}','{9}');",
                entidad.Grupo, entidad.Descripcion, entidad.CantidadAsientosBajos, entidad.CantidadAsientosMedios, entidad.CantidadAsientosAltos, entidad.CostoAsientosAltos, entidad.CostoAsientosMedios, entidad.CostoAsientosBajos, entidad.CantidadAsientosDiscapacitados, entidad.CostoAsientosDiscapacitados);

          return  conexion.NonQuery(query);
        }

        public void Modificar(Espectaculo entidad)
        {
            //string query = string.Format("UPDATE dbo.Espectaculo SET Nombre='{0}',Descripcion='{1}',Horario='{2}' WHERE IdMenu= '{3}'; ", entidad.Nombre, entidad.Descripcion, entidad.Horario, entidad.ID);

            string query = string.Format("UPDATE dbo.Espectaculos SET Grupo='{0}',Descripcion='{1}',CantidadAsientosBajos='{2}',CantidadAsientosMedios='{3}',CantidadAsientosAltos='{4}',CostoAsientosAltos='{5}',CostoAsientosMedio='{6}',CostoAsientosBajos='{7}',CantidadAsientosDiscapacitados='{8}',CostoAsientosDiscapacitados='{9}', WHERE Id= '{3}'; ",
                 entidad.Grupo, entidad.Descripcion, entidad.CantidadAsientosBajos, entidad.CantidadAsientosMedios, entidad.CantidadAsientosAltos, entidad.CostoAsientosAltos, entidad.CostoAsientosMedios, entidad.CostoAsientosBajos, entidad.CantidadAsientosDiscapacitados, entidad.CostoAsientosDiscapacitados);



            
            conexion.NonQuery(query);
        }
        public DataTable precioAsientoBajo(int id) {

            string query = string.Format("SELECT CostoAsientosBajos FROM Espectaculos Where Id = {0};", id);

            return conexion.ConexionADO(query);

        }
        public DataTable precioAsientomedio(int id)
        {

            string query = string.Format("SELECT CostoAsientosMedio FROM Espectaculos Where Id = {0};", id);

            return conexion.ConexionADO(query);

        }
        public DataTable precioAsientoAlto(int id)
        {

            string query = string.Format("SELECT CostoAsientosAltos FROM Espectaculos Where Id = {0};", id);

            return conexion.ConexionADO(query);

        }
        public DataTable precioAsientoDiscapacitado(int id)
        {

            string query = string.Format("SELECT CostoAsientosDiscapacitados FROM Espectaculos Where Id = {0};", id);

            return conexion.ConexionADO(query);

        }
       
        public void ModificarCantidadAsientosBajos(int cantidad, int evento) {


            string query = string.Format("UPDATE dbo.Espectaculos SET CantidadAsientosBajos='{0}' WHERE Id = '{1}';",cantidad,evento);

            conexion.NonQuery(query);

        }

        public void ModificarCantidadAsientosMedios(int cantidad, int evento)
        {


            string query = string.Format("UPDATE dbo.Espectaculos SET CantidadAsientosMedios='{0}', WHERE Id = '{1}';", cantidad, evento);

            conexion.NonQuery(query);

        }
        public void ModificarCantidadAsientosAltos(int cantidad, int evento)
        {


            string query = string.Format("UPDATE dbo.Espectaculos SET CantidadAsientosAltos='{0}', WHERE Id = '{1}';", cantidad, evento);

            conexion.NonQuery(query);

        }

        public void ModificarCantidadAsientosDiscapacitados(int cantidad, int evento)
        {


            string query = string.Format("UPDATE dbo.Espectaculos SET CantidadAsientosDiscapacitados='{0}', WHERE Id = '{1}';", cantidad, evento);

            conexion.NonQuery(query);

        }

        public DataTable BuscarTodosEventos()
        {
            string query = string.Format("SELECT Id,Grupo FROM Espectaculos;");

            return conexion.ConexionADO(query);
        }
        //   string query = string.Format("INSERT INTO dbo.Espectaculos (Grupo,Descripcion,CantidadAsientosBajos,CantidadAsientosMedios,CantidadAsientosAltos,CostoAsientosAltos,CostoAsientosMedio,CostoAsientosBajos,CantidadAsientosDiscapacitados,CostoAsientosDiscapacitados)" + "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',('{6}','{7}','{8}','{9}');",
       // entidad.Grupo, entidad.Descripcion, entidad.CantidadAsientosBajos, entidad.CantidadAsientosMedios, entidad.CantidadAsientosAltos, entidad.CostoAsientosAltos, entidad.CostoAsientosMedios, entidad.CostoAsientosBajos, entidad.CantidadAsientosDiscapacitados, entidad.CostoAsientosDiscapacitados);

        public DataTable BuscarCantidadAsientoBajo(int id)
        {
            string query = string.Format("SELECT CantidadAsientosBajos FROM Espectaculos WHERE Id = {0};", id);

            return conexion.ConexionADO(query);
        }
        public DataTable BuscarCantidadAsientosMedio(int id)
        {
            string query = string.Format("SELECT CantidadAsientosMedios FROM Espectaculos WHERE Id = {0};", id);

            return conexion.ConexionADO(query);
        }
        public DataTable BuscarCantidadAsientosAltos(int id)
        {
            string query = string.Format("SELECT CantidadAsientosAltos FROM Espectaculos WHERE Id = {0};", id);

            return conexion.ConexionADO(query);
        }
        public DataTable BuscarCantidadAsientosDiscapacitados(int id)
        {
            string query = string.Format("SELECT CantidadAsientosDiscapacitados FROM Espectaculos WHERE Id = {0};", id);

            return conexion.ConexionADO(query);
        }


        public DataTable PrecioAsientoBajo(int id)
        {
            string query = string.Format("SELECT CostoAsientosBajos FROM Espectaculos WHERE Id = {0};", id);

            return conexion.ConexionADO(query);
        }
        public DataTable PrecioAsientoMedio(int id)
        {
            string query = string.Format("SELECT CostoAsientosMedio FROM Espectaculos WHERE Id = {0};", id);

            return conexion.ConexionADO(query);
        }
        public DataTable PrecioAsientoAlto(int id)
        {
            string query = string.Format("SELECT CostoAsientosAltos FROM Espectaculos WHERE Id = {0};", id);

            return conexion.ConexionADO(query);
        }
        public DataTable PrecioAsientoDiscapacitado(int id)
        {
            string query = string.Format("SELECT CostoAsientosDiscapacitados FROM Espectaculos WHERE Id = {0};", id);

            return conexion.ConexionADO(query);
        }
        //string query = string.Format("INSERT INTO dbo.Espectaculos (Grupo,Descripcion,CantidadAsientosBajos,CantidadAsientosMedios,CantidadAsientosAltos,CostoAsientosAltos,CostoAsientosMedio,CostoAsientosBajos,CantidadAsientosDiscapacitados,CostoAsientosDiscapacitados)" + "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',('{6}','{7}','{8}','{9}');",
        //        entidad.Grupo, entidad.Descripcion, entidad.CantidadAsientosBajos, entidad.CantidadAsientosMedios, entidad.CantidadAsientosAltos, entidad.CostoAsientosAltos, entidad.CostoAsientosMedios, entidad.CostoAsientosBajos, entidad.CantidadAsientosDiscapacitados, entidad.CostoAsientosDiscapacitados);

    }
}

//string query = string.Format("SELECT CantidadAsientosBajos,CantidadAsientosMedios,CantidadAsientosAltos," +
//               "CostoAsientosAltos,CostoAsientosMedio,CostoAsientosBajos," +
//               "CantidadAsientosDiscapacitados,CostoAsientosDiscapacitados FROM Espectaculos Where Id = {0};", id);

//spectaculos(Grupo, Descripcion, CantidadAsientosBajos, CantidadAsientosMedios, 
//    CantidadAsientosAltos, CostoAsientosAltos, CostoAsientosMedio, CostoAsientosBajos, 
//    CantidadAsientosDiscapacitados, CostoAsientosDiscapacitados)" + "VALUES('{0}','
