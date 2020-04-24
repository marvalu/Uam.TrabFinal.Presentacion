using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uam.TrabFinal.Logica;
using Uam.TrabFinal.Entidades;
using Microsoft.VisualBasic;
using Uam.TrabFinal.Datos;
using System.Data;

namespace Uam.TrabFinal.Logica
{
    public class OperacionesLogica
    {
        conexion cnn = new conexion();
        OperacionesLogin op = new OperacionesLogin();
        IOperacionesPersona opPersona = new IOperacionesPersona();

        IOperacionesEspectaculo operacionesEspectaculo = new IOperacionesEspectaculo();

        //  Persona persona = new Persona();
        public Boolean login(Usuario user)
        {

            try
            {
                Boolean respuesta;



                if (respuesta = op.Ingreso(user))
                {

                    return true;

                }
                else
                {

                    return false;


                }



            }
            catch (Exception ex)
            {

                Interaction.MsgBox("LogicaNegocio.login" + ex.Message, 0, "Advertencia");

            }

            return false;
        }
        public void ModificaEspectaculo(Espectaculo espectaculo)
        {

            operacionesEspectaculo.Modificar(espectaculo);

        }

        public void EliminarEspectaculo(int id)
        {

            operacionesEspectaculo.Elminiar(id);
        }
        public bool AgregarEspectaculoNuevo(Espectaculo espectaculo)
        {

            try
            {
                if (operacionesEspectaculo.Insertar(espectaculo))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                Interaction.MsgBox("Error " + ex);
                return false;
            }


        }

        public Boolean ValidarEntradaDisponible(int evento, int cantidadCompra, int CantidadTotales, int TipoAsiento)
        {
            //CantidadAsientosBajos =1
            //CantidadAsientosMedios=2
            //CantidadAsientosAltos=3
            //CantidadAsientosDiscapacitados=4
            //Ayuda para entender el switch
            int nuevaCantidad;
            Boolean Exito = false; //validar si se pudo realizar la compra


            switch (TipoAsiento)
            {

                case 1:
                    //CantidadAsientosBajos =1
                    if ((CantidadTotales - cantidadCompra) >= 0)
                    {
                        nuevaCantidad = CantidadTotales - cantidadCompra;
                        operacionesEspectaculo.ModificarCantidadAsientosBajos(nuevaCantidad, evento);
                        Exito = true;
                    }
                    else
                    {
                        Exito = false;

                    }
                    break;

                case 2:
                    //CantidadAsientosMedios=2
                    if ((CantidadTotales - cantidadCompra) >= 0)
                    {
                        nuevaCantidad = CantidadTotales - cantidadCompra;
                        operacionesEspectaculo.ModificarCantidadAsientosMedios(nuevaCantidad, evento);
                        Exito = true;
                    }
                    else
                    {
                        Exito = false;

                    }
                    break;
                case 3:
                    //CantidadAsientosAltos=3
                    if ((CantidadTotales - cantidadCompra) >= 0)
                    {
                        nuevaCantidad = CantidadTotales - cantidadCompra;
                        operacionesEspectaculo.ModificarCantidadAsientosAltos(nuevaCantidad, evento);
                        Exito = true;
                    }
                    else
                    {
                        Exito = false;

                    }
                    break;
                case 4:
                    //CantidadAsientosDiscapacitados=4
                    if ((CantidadTotales - cantidadCompra) >= 0)
                    {
                        nuevaCantidad = CantidadTotales - cantidadCompra;
                        operacionesEspectaculo.ModificarCantidadAsientosDiscapacitados(nuevaCantidad, evento);
                        Exito = true;
                    }
                    else
                    {
                        Exito = false;

                    }
                    break;

            }




            return Exito;

        }
        //Operaciones Persona
        //Metodo para crear una persona
        //public void crearPersona(Persona persona)
        //{

        //    try
        //    {
        //        if (!listaPersona.Contains(persona))
        //        {
        //            operacionesPersona.Insertar(persona);
        //            listaPersona.Add(persona);
        //            Console.WriteLine("Persona ingresada con exito!");
        //        }
        //        else
        //        {
        //            Console.WriteLine("La persona que intenta ingresar ya existe!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Ocurrio un error ingresando persona: " + ex);
        //    }
        //}
        ////Metodo para eliminar a una persona
        //public void eliminarPersona(Persona id)
        //{
        //    try
        //    {
        //        if (listaPersona.Contains(id))
        //        {
        //            operacionesPersona.Elminiar(id);
        //            listaPersona.Remove(id);
        //            Console.WriteLine("Persona eliminada con exito!");
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Ocurrio un error eliminando Persona: " + ex);
        //    }
        //}
        ////Metodo para buscar a todas las personas
        //public DataTable BuscarTodosP()
        //{
        //    try
        //    {
        //        if (listaPersona != null)
        //        {
        //            return operacionesPersona.BuscarTodos();
        //        }
        //        else
        //        {
        //            Console.WriteLine("La lista se encuentra vacia!");
        //            return null;
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Ocurrio en un error mientras se realizaba la busqueda: " + ex);
        //        return null;
        //    }
        //}
        ////Metodo para buscar una unica persona mediante id
        //public DataTable BuscarPersona(int id)
        //{

        //    return operacionesPersona.Buscar(id);
        //}

        ////Operaciones de espectaculos
        ////Metodo para ingresar un espectaculo
        //public void ingresarEspectaculo(Espectaculo espectaculo)
        //{

        //    try
        //    {
        //        if (!listaEspectaculo.Contains(espectaculo))
        //        {
        //            operacionesEspectaculo.Insertar(espectaculo);
        //            listaEspectaculo.Add(espectaculo);
        //            Console.Write("Espectaculo agregado con exito a la lista!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Ocurrio un error insertando un espectaculo: " + ex);
        //    }
        //}
        ////Metodo para eliminar un espectaculo
        //public void EliminarEspectaculo(Espectaculo id)
        //{
        //    try
        //    {
        //        if (listaEspectaculo.Contains(id))
        //        {
        //            operacionesEspectaculo.Elminiar(id);
        //            listaEspectaculo.Remove(id);
        //            Console.WriteLine("Espectaculo eliminado con exito!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.Write("Ocurrio un error eliminando espectaculo: " + ex);
        //    }

        //}
        ////Metodo para buscar todos los espectaculos
        //public DataTable BuscarTodosE()
        //{
        //    try
        //    {
        //        if (listaPersona != null)
        //        {
        //            return operacionesEspectaculo.BuscarTodos();
        //        }
        //        else
        //        {
        //            Console.WriteLine("La lista se encuentra vacia!");
        //            return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Ocurrio un error buscando los espectaculos: " + ex);
        //        return null;
        //    }
        //}
        ////Metodo para buscar un unico espectaculo por medio de id
        //public DataTable BuscarEspectaculos(int id)
        //{
        //    return operacionesEspectaculo.Buscar(id);
        //}

        public bool Insertar(Persona entidad)
        {

            try
            {
                if (opPersona.Insertar(entidad))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al ingresarPersona" + ex);
                return false;
            }

        }

        public void Eliminar(int id)
        {
            try
            {
                opPersona.Elminiar(id);
            }
            catch (Exception ex)
            {

                Interaction.MsgBox("Error al Eliminar Persona" + ex);
            }
        }

        public DataTable MostarDatos()
        {
            return opPersona.BuscarTodos();
        }

        public void Modificar(Persona entidad)
        {
            try
            {
                opPersona.Modificar(entidad);
            }
            catch (Exception ex)
            {

                Interaction.MsgBox("Error al Modificar Persona" + ex);
            }
        }


        public DataTable mostrarTodosEventos()
        {

            return operacionesEspectaculo.BuscarTodosEventos();

        }
        public DataTable mostrarAsientos(int id)
        {

            return operacionesEspectaculo.Buscar(id);

        }

        public DataTable PrecioAsientoBajo(int id)
        {

            return operacionesEspectaculo.PrecioAsientoBajo(id);
        }
        public DataTable PrecioAsientoMedio(int id)
        {

            return operacionesEspectaculo.PrecioAsientoMedio(id);
        }
        public DataTable PrecioAsientoAlto(int id)
        {

            return operacionesEspectaculo.PrecioAsientoAlto(id);
        }
        public DataTable PrecioAsientoDiscapacitado(int id)
        {

            return operacionesEspectaculo.PrecioAsientoDiscapacitado(id);
        }
        public DataTable CantidadAsientoBajo(int id) {

           return operacionesEspectaculo.BuscarCantidadAsientoBajo(id);
        
        }
        public DataTable CantidadAsientoMedio(int id)
        {

            return operacionesEspectaculo.BuscarCantidadAsientosMedio(id);

        }
        public DataTable CantidadAsientoalto(int id)
        {

            return operacionesEspectaculo.BuscarCantidadAsientosAltos(id);

        }
        public DataTable CantidadAsientoDiscapacitado(int id)
        {

            return operacionesEspectaculo.BuscarCantidadAsientosDiscapacitados(id);

        }
    }
}
