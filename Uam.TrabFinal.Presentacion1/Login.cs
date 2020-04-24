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
            Persona usr = new Persona();

            usr.Nombre = texUsuario.Text;
            usr.Password = texClave.Text;
            usr.TipoUsuario = comboTipo.Text;

            usr = sc.ExecuteClientObject(usr);

            if (usr != null)
            {
                if (usr.TipoUsuario.Equals("Administrador"))
                {
                    MessageBox.Show("Bienvenido Administrador");
                    Menu acceso = new Menu();

                    acceso.Visible = true;

                    Visible = false;
                }
                else
                {
                    if (usr.TipoUsuario.Equals("Usuario"))
                    {
                        MessageBox.Show("Bienvenido" + usr.Nombre);
                        Ventas ventas = new Ventas();
                        ventas.UsuarioRecibido(usr);
                        ventas.Visible = true;
                        this.Visible = false;
                    }
                }


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