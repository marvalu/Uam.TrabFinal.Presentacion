
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uam.TrabFinal.Entidades;
using Uam.TrabFinal.Logica;

namespace Uam.TrabFinal.Presentacion1
{
    public partial class Personas : Form
    {
        OperacionesLogica opLog = new OperacionesLogica();
        Persona per = new Persona();
        public Personas()
        {
            InitializeComponent();
            Tabla();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Boolean resp;
            per.Nombre = textNombre.Text;
            per.Apellido = textApellido.Text;
            per.Cedula = textCed.Text;
            per.Email = textEmail.Text;
            per.Password = textPass.Text;

            if(rdAdmin.Checked == true)
            {
                per.TipoUsuario = "Administrador";
            }
            else if(rdUsr.Checked == true)
            {
                per.TipoUsuario = "Usuario";
                
            }
           resp = opLog.Insertar(per);
            LimpiarCampos();
            Tabla();

            if(resp != false)
            {
                MessageBox.Show("Agregado correctamente");
            }
            else
            {
                MessageBox.Show("Fallo al agregar");
            }
        }

        void Tabla()
        {
            DataTable data = new DataTable();
            data = opLog.MostarDatos();
            dataGridPersona.DataSource = data;

        }

        public void LimpiarCampos()
        {
            textNombre.Text = "";
            textApellido.Text = "";
            textCed.Text = "";
            textEmail.Text = "";
            textPass.Text = "";
            rdAdmin.Checked = false;
            rdUsr.Checked = false;
            textModificar.Text = "";
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            opLog.Eliminar(int.Parse(textModificar.Text));
            MessageBox.Show("Eliminado correctamente");
            LimpiarCampos();
            Tabla();
        }
    }
}
