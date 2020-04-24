//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Text;
//using System.Threading.Tasks;

//namespace Uam.TrabFinal.Entidades
//{
//    [Serializable]
//    //public class Usuario
//    //{

//    //    private string usr;
//    //    private String _password;

//    //    public string Usr { get => usr; set => usr = value; }
//    //    public string Password { get => _password; set => _password = value; }

//    //    public Usuario()
//    //    {
//    //    }

//    //    public Usuario(string usr, string password)
//    //    {
//    //        usr = usr;
//    //        _password = password;
//    //    }

//    //    public byte[] Serialize()
//    //    {
//    //        BinaryFormatter bin = new BinaryFormatter();
//    //        MemoryStream mem = new MemoryStream();
//    //        bin.Serialize(mem, this);
//    //        return mem.GetBuffer();
//    //    }

//    //    public Usuario DeSerialize(byte[] TransmissionBuffer)
//    //    {
//    //        byte[] dataBuffer = TransmissionBuffer.ToArray();
//    //        BinaryFormatter bin = new BinaryFormatter();
//    //        MemoryStream mem = new MemoryStream();
//    //        mem.Write(dataBuffer, 0, dataBuffer.Length);
//    //        mem.Seek(0, 0);

//    //        return (Usuario)bin.Deserialize(mem);
//    //    }
//    }
//}
