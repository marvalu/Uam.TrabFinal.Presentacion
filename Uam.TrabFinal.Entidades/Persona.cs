using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Uam.TrabFinal.Entidades
{
    [Serializable]
    public class Persona 
    {


        private int _id;
        private string _nombre;
        private string _apellido;
        private string _cedula;
        private string _email;
        private string _tipoUsuario;
        private string _password;
        

     

        
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }
        public string Email { get => _email; set => _email = value; }
        public string TipoUsuario { get => _tipoUsuario; set => _tipoUsuario = value; }
        public string Password { get => _password; set => _password = value; }
        public int Id { get => _id; set => _id = value; }



        public Persona(string nombre, string apellido, string cedula, string email, string tipoUsuario, string password, int id)
        {
            
            _nombre = nombre;
            _apellido = apellido;
            _cedula = cedula;
            _email = email;
            _tipoUsuario = tipoUsuario;
            _password = password;
            _id = id;
            
        }

        public Persona(string nombre, string password, string tipoUsuario)
        {
            _nombre = nombre;
            _password = password;
            _tipoUsuario = tipoUsuario;
        }

        public Persona() { }

        public byte[] Serialize()
        {
            BinaryFormatter bin = new BinaryFormatter();
            MemoryStream mem = new MemoryStream();
            bin.Serialize(mem, this);
            return mem.GetBuffer();
        }

        public Persona DeSerialize(byte[] TransmissionBuffer)
        {
            byte[] dataBuffer = TransmissionBuffer.ToArray();
            BinaryFormatter bin = new BinaryFormatter();
            MemoryStream mem = new MemoryStream();
            mem.Write(dataBuffer, 0, dataBuffer.Length);
            mem.Seek(0, 0);

            return (Persona)bin.Deserialize(mem);
        }
    }
}
