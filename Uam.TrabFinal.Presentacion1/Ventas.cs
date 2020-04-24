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

namespace Uam.TrabFinal.Presentacion1
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        public void UsuarioRecibido(Personas per) { 
        }

        internal void UsuarioRecibido(Persona usr)
        {
            throw new NotImplementedException();
        }
    }
}
