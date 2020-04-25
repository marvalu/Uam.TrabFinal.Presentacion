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

namespace Uam.TrabFinal.Presentacion1
{
    public partial class Auditoria : Form
    {

        OperacionesLogica opLog = new OperacionesLogica();
        public Auditoria()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Volviendo al menu principal!");
            this.Close();
        }
        void tabla()
        {
            DataTable data = new DataTable();
         //   data = opLog.mostrarAuditoria();
            dgvAuditoria.DataSource = data;


        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            tabla();
        }
    }
}