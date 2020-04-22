using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uam.TrabFinal.Logica;
using Uam.TrabFinal.Entidades;
using Uam.TrabFinal.SocketCliente;

namespace Uam.TrabFinal.Presentacion1
{
    public partial class Login : Form
    {
        ProgramCliente sc = new ProgramCliente();
        OperacionesLogica op = new OperacionesLogica();
        public Login()
        {
            InitializeComponent();
            texClave.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            Usuario usr;
            usr = sc.ExecuteClientObject(new Usuario(texUsuario.Text, texClave.Text));
           

            if (usr != null)
            {
                //se valida tipo por medio de atributo se decide si llama menu condicionado para 
                MessageBox.Show("Bienvenido Administrador");
                Menu acceso = new Menu();
                acceso.Visible = true;

                Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectas");
            }




        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}