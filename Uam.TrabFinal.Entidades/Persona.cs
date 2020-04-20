using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uam.TrabFinal.Entidades
{
    public class Persona 
    {


       
        private string _nombre;
        private string _apellido;
        private string _cedula;
        private string _email;
        private string _tipoUsuario;
        

     

        
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }
        public string Email { get => _email; set => _email = value; }
        public string TipoUsuario { get => _tipoUsuario; set => _tipoUsuario = value; }
       


        public Persona(string nombre, string apellido, string cedula, string email, string tipoUsuario)
        {
            
            _nombre = nombre;
            _apellido = apellido;
            _cedula = cedula;
            _email = email;
            _tipoUsuario = tipoUsuario;
            
        }

        public Persona(string nombre, string cedula)
        {
            _nombre = nombre;
            _cedula = cedula;
        }

        public Persona() { }
    }
}
