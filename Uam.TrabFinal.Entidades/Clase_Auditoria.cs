using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uam.TrabFinal.Entidades
{
    public class Clase_Auditoria
    {
        private int _idCliente;
        private int _idEvento;
        private int _cantAsientos;
        private string _localidad;
        private int _costoTotal;

        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdEvento { get => _idEvento; set => _idEvento = value; }
        public int CantAsientos { get => _cantAsientos; set => _cantAsientos = value; }
        public string Localidad { get => _localidad; set => _localidad = value; }
        public int CostoTotal { get => _costoTotal; set => _costoTotal = value; }


        public Clase_Auditoria() { }
        public Clase_Auditoria(int idCliente, int idEvento, int cantAsientos, string localidad, int costoTotal)
        {
            IdCliente = idCliente;
            IdEvento = idEvento;
            CantAsientos = cantAsientos;
            Localidad = localidad;
            CostoTotal = costoTotal;
        }

    }

}