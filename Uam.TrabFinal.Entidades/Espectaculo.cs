using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uam.TrabFinal.Entidades
{
    public class Espectaculo
    {


        private int _id;
        private string _grupo;
        private string _descripcion;
        private int _cantidadAsientosBajos;
        private int _costoAsientosBajos;
        private int _cantidadAsientosMedios;
        private int _costoAsientosMedios;
        private int _cantidadAsientosAltos;
        private int _costoAsientosAltos;
        private int _cantidadAsientosDiscapacitados;
        private int _costoAsientosDiscapacitados;



        public int Id { get => _id; set => _id = value; }
        public string Grupo { get => _grupo; set => _grupo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int CantidadAsientosBajos { get => _cantidadAsientosBajos; set => _cantidadAsientosBajos = value; }
        public int CostoAsientosBajos { get => _costoAsientosBajos; set => _costoAsientosBajos = value; }
        public int CantidadAsientosMedios { get => _cantidadAsientosMedios; set => _cantidadAsientosMedios = value; }
        public int CostoAsientosMedios { get => _costoAsientosMedios; set => _costoAsientosMedios = value; }
        public int CantidadAsientosAltos { get => _cantidadAsientosAltos; set => _cantidadAsientosAltos = value; }
        public int CostoAsientosAltos { get => _costoAsientosAltos; set => _costoAsientosAltos = value; }
        public int CantidadAsientosDiscapacitados { get => _cantidadAsientosDiscapacitados; set => _cantidadAsientosDiscapacitados = value; }
        public int CostoAsientosDiscapacitados { get => _costoAsientosDiscapacitados; set => _costoAsientosDiscapacitados = value; }


        public Espectaculo(int id, string grupo, string descripcion, int cantidadAsientosBajos, int costoAsientosBajos, int cantidadAsientosMedios, int costoAsientosMedios, int cantidadAsientosAltos, int costoAsientosAltos, int cantidadAsientosDiscapacitados, int costoAsientosDiscapacitados)
        {
            _id = id;
            _grupo = grupo;
            _descripcion = descripcion;
            _cantidadAsientosBajos = cantidadAsientosBajos;
            _costoAsientosBajos = costoAsientosBajos;
            _cantidadAsientosMedios = cantidadAsientosMedios;
            _costoAsientosMedios = costoAsientosMedios;
            _cantidadAsientosAltos = cantidadAsientosAltos;
            _costoAsientosAltos = costoAsientosAltos;
            _cantidadAsientosDiscapacitados = cantidadAsientosDiscapacitados;
            _costoAsientosDiscapacitados = costoAsientosDiscapacitados;
        }

        public Espectaculo() { }



        //public Espectaculo(string grupo, string descripcion, int cantidadAsientosBajos, int costoAsientosBajos, int cantidadAsientosMedios, int costoAsientosMedios, int cantidadAsientosAltos, int costoAsientosAltos, int cantidadAsientosDiscapacitados, int costoAsientosDiscapacitados)
        //{

        //    _grupo = grupo;
        //    _descripcion = descripcion;
        //    _cantidadAsientosBajos = cantidadAsientosBajos;
        //    _costoAsientosBajos = costoAsientosBajos;
        //    _cantidadAsientosMedios = cantidadAsientosMedios;
        //    _costoAsientosMedios = costoAsientosMedios;
        //    _cantidadAsientosAltos = cantidadAsientosAltos;
        //    _costoAsientosAltos = costoAsientosAltos;
        //    _cantidadAsientosDiscapacitados = cantidadAsientosDiscapacitados;
        //    _costoAsientosDiscapacitados = costoAsientosDiscapacitados;
        //}
    }
}