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
    public partial class Espectaculos : Form
    {
        
        OperacionesLogica operacionesLogica = new OperacionesLogica();

        public Espectaculos()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            //public Espectaculo(int id, string grupo, string descripcion, int cantidadAsientosBajos, int costoAsientosBajos, int cantidadAsientosMedios, int costoAsientosMedios, int cantidadAsientosAltos, int costoAsientosAltos, int cantidadAsientosDiscapacitados, int costoAsientosDiscapacitados)

            try
            {
                Uam.TrabFinal.Entidades.Espectaculo espectaculos = new Uam.TrabFinal.Entidades.Espectaculo(int.Parse(txId.Text), textGrupo.Text, textDescrip.Text, int.Parse(textBajos.Text), int.Parse(textCostoBajos.Text), int.Parse(textMedios.Text), int.Parse(textCostoMedios.Text), int.Parse(textAltos.Text), int.Parse(textCostoAltos.Text), int.Parse(textDisca.Text), int.Parse(textCostoDisca.Text));


                operacionesLogica.AgregarEspectaculoNuevo(espectaculos);
            }
            catch (Exception)
            {

                MessageBox.Show("Error insertando");
            }

            
        }

        private void btEliminar_Click(object sender, EventArgs e)

        {
            try
            {
                operacionesLogica.EliminarEspectaculo(int.Parse(txId.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Error eliminando");
            }
         
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Uam.TrabFinal.Entidades.Espectaculo espectaculos = new Uam.TrabFinal.Entidades.Espectaculo(int.Parse(txId.Text), textGrupo.Text, textDescrip.Text, int.Parse(textBajos.Text), int.Parse(textCostoBajos.Text), int.Parse(textMedios.Text), int.Parse(textCostoMedios.Text), int.Parse(textAltos.Text), int.Parse(textCostoAltos.Text), int.Parse(textDisca.Text), int.Parse(textCostoDisca.Text));
                operacionesLogica.ModificaEspectaculo(espectaculos);
            }
            catch (Exception)
            {

                MessageBox.Show("Error modificando");
            }
        }
    }
}
