using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uam.TrabFinal.Logica;
using Uam.TrabFinal.Entidades;
using Microsoft.VisualBasic;

namespace Uam.TrabFinal.Logica
{
    public class OperacionesLogica
    {
        OperacionesLogin op = new OperacionesLogin();

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
    }
}
