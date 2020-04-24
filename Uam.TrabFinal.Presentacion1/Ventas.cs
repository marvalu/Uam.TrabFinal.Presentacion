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
    public partial class Ventas : Form

    {
        int preciosAsientosBajos, PreciosAsientosMedios, PrecioAsientosAltos, PrecioDiscapacitado;
        int cantidadBajos, CantidadAltos, CantidadMedio, CantidadDiscapacitado;
        int EventoID;
        string h;
        string temporalPrecio;

        OperacionesLogica operacionesLogica = new OperacionesLogica();
        public Ventas()
        {
            InitializeComponent();
            TablaEventos();
        }

        void TablaEventos()
        {
            DataTable table = new DataTable();
            table = operacionesLogica.mostrarTodosEventos();
            GridEspectaculos.DataSource = table;
        }

        void TablaCupos() {

            DataTable tableCupo = new DataTable();
            tableCupo = operacionesLogica.mostrarTodosEventos();
            GridCupos.DataSource = tableCupo;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Comprar_Click(object sender, EventArgs e)
        {
            Boolean realizada = false;
            string temporalCantidad1;
            int temporalPrecio3;

            DataTable table2 = new DataTable();
            string temp;

          //  table2 = operacionesLogica.PrecioAsientoBajo(int.Parse(h));
           
           // temporalCantidad1 = table2.Rows[0][0].ToString(); // ToString();
            table2 = operacionesLogica.PrecioAsientoBajo(int.Parse(h));
            temp = table2.Rows[0][0].ToString();
            preciosAsientosBajos = int.Parse(temp);

            table2 = operacionesLogica.PrecioAsientoMedio(int.Parse(h));

           // temporalCantidad1 = table2.Rows[0][0].ToString(); // ToString();
            table2 = operacionesLogica.PrecioAsientoMedio(int.Parse(h));
            temp = table2.Rows[0][0].ToString();
            PreciosAsientosMedios = int.Parse(temp);

           // temporalCantidad1 = table2.Rows[0][0].ToString(); // ToString();
            table2 = operacionesLogica.PrecioAsientoAlto(int.Parse(h));
            temp = table2.Rows[0][0].ToString();
            PrecioAsientosAltos = int.Parse(temp);

            //temporalCantidad1 = table2.Rows[0][0].ToString(); // ToString();
            table2 = operacionesLogica.PrecioAsientoDiscapacitado(int.Parse(h));
            temp = table2.Rows[0][0].ToString();
            PrecioDiscapacitado= int.Parse(temp);

           // temporalCantidad1 = table2.Rows[0][0].ToString(); // ToString();
            table2 = operacionesLogica.CantidadAsientoalto(int.Parse(h));
            temp = table2.Rows[0][0].ToString();
            CantidadAltos = int.Parse(temp);

          //  temporalCantidad1 = table2.Rows[0][0].ToString(); // ToString();
            table2 = operacionesLogica.CantidadAsientoMedio(int.Parse(h));
            temp = table2.Rows[0][0].ToString();
            CantidadMedio = int.Parse(temp);

          //  temporalCantidad1 = table2.Rows[0][0].ToString(); // ToString();
            table2 = operacionesLogica.CantidadAsientoDiscapacitado(int.Parse(h));
            temp = table2.Rows[0][0].ToString();
            CantidadDiscapacitado = int.Parse(temp);

           // temporalCantidad1 = table2.Rows[0][0].ToString(); // ToString();
            table2 = operacionesLogica.CantidadAsientoBajo(int.Parse(h));
            temp = table2.Rows[0][0].ToString();
            cantidadBajos = int.Parse(temp);
            //antidadBajos, CantidadAltos, CantidadMedio, CantidadDiscapacitado;

            //int temporalCantidad2=int.Parse(temporalCantidad1);
            //temporalPrecio3 = int.Parse(Cantidad.Text) * int.Parse(temporalCantidad1);

            //cantidadBajos = temporalCantidad2;
            //table2 = operacionesLogica.PrecioAsientoMedio(int.Parse(h));
            //temporalPrecio = table2.Rows[0][0].ToString(); // ToString();
            //CantidadMedio = temporalCantidad2;
            //table2 = operacionesLogica.PrecioAsientoAlto(int.Parse(h));
            //temporalPrecio = table2.Rows[0][0].ToString(); // ToString();
            //CantidadAltos = temporalCantidad2;
            //table2 = operacionesLogica.PrecioAsientoDiscapacitado(int.Parse(h));
            //temporalPrecio = table2.Rows[0][0].ToString(); // ToString();
            //CantidadDiscapacitado = temporalCantidad2;

            //
            //int evento, int cantidadCompra, int CantidadTotales, int TipoAsiento)
            // int preciosAsientosBajos, PreciosAsientosMedios, PrecioAsientosAltos, PrecioDiscapacitado;
            //int cantidadBajos, CantidadAltos, CantidadMedio, CantidadDiscapacitado;
            temporalPrecio3 = 0;
            if (AsientoBajos.Checked == true)
            {
                realizada = operacionesLogica.ValidarEntradaDisponible(EventoID, (int.Parse(Cantidad.Text)), cantidadBajos, 1);
                temporalPrecio3 = int.Parse(Cantidad.Text) * preciosAsientosBajos;
            }
            else if (AsientoMedio.Checked == true)
            {
                realizada = operacionesLogica.ValidarEntradaDisponible(EventoID, (int.Parse(Cantidad.Text)), CantidadMedio, 2);
                temporalPrecio3 = int.Parse(Cantidad.Text) * PreciosAsientosMedios;
            }
            else if (AsientoAlto.Checked == true)
            {
                realizada = operacionesLogica.ValidarEntradaDisponible(EventoID, (int.Parse(Cantidad.Text)), CantidadAltos, 3);
                temporalPrecio3 = int.Parse(Cantidad.Text) * PrecioAsientosAltos;
            }
            else if (AsientoDiscapacitado.Checked == true)
            {
                realizada = operacionesLogica.ValidarEntradaDisponible(EventoID, (int.Parse(Cantidad.Text)), CantidadDiscapacitado, 4);
                temporalPrecio3 = int.Parse(Cantidad.Text) * CantidadDiscapacitado;
            }
            else {
                MessageBox.Show("No se determina informacion para realizar la compra");
            }                //CantidadAsientosBajos =1
                             //CantidadAsientosMedios=2
                             //CantidadAsientosAltos=3
                             //CantidadAsientosDiscapacitados=4
            if (realizada == true) { MessageBox.Show("Compra Exitosa"); }
            else { MessageBox.Show("No se efectuo la compra"); }
            
            MessageBox.Show("Total de Compra\n",temporalPrecio3.ToString());
            TablaEventos();
          
        }
    
        

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int rowindex = GridEspectaculos.CurrentRow.Index;
            DataGridViewRow row = GridEspectaculos.Rows[rowindex];
            h = row.Cells[0].Value.ToString();
            EventoID = int.Parse(h);
            //GridCupos


       

            

            ////DataGridViewRow row12 = this.dataGridView1.SelectedRows[0];
            ////row.Cells["ColumnName"].Value

            ////dg_menu.CurrentRow.Cells. CurrentRow.Cells["ColumnName"].Value
            DataTable table1 = new DataTable();
            table1 = operacionesLogica.mostrarAsientos(int.Parse(h));

            DataTable table2 = new DataTable();
            
            GridCupos.DataSource = table1;

            //table2 = operacionesLogica.PrecioAsientoBajo(int.Parse(h));
            //temporalPrecio = table2.Rows[0][0].ToString(); // ToString();
            // int precio = int.Parse(Cantidad.Text) * (int.Parse(temporalPrecio));
            //preciosAsientosBajos = precio;
            //table2 = operacionesLogica.PrecioAsientoMedio(int.Parse(h));
            //temporalPrecio = table2.Rows[0][0].ToString(); // ToString();
            //PreciosAsientosMedios = precio;
            //table2 = operacionesLogica.PrecioAsientoAlto(int.Parse(h));
            //temporalPrecio = table2.Rows[0][0].ToString(); // ToString();
            //PrecioAsientosAltos = precio;
            //table2 = operacionesLogica.PrecioAsientoDiscapacitado(int.Parse(h));
            //temporalPrecio = table2.Rows[0][0].ToString(); // ToString();
            //PrecioDiscapacitado = precio;

            //  MessageBox.Show(precio);
            //MessageBox.Show(precio.ToString());
            //string h1 = row.Cells[0].Value.ToString();



            //int rowindex1 = GridEspectaculos.CurrentRow.Index;
            //DataGridViewRow row1 = GridEspectaculos.Rows[rowindex];
            //string h1 = row.Cells[0].Value.ToString();
            //int EventoID1 = int.Parse(h);

//            preciosAsientosBajos, PreciosAsientosMedios, PrecioAsientosAltos, PrecioDiscapacitado;


        }

        private void GridCupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int rowindex = GridCupos.CurrentRow.Index;
            
            //DataGridViewRow row = GridCupos.Rows[rowindex];
            //string h = row.Cells[0].Value.ToString();
            //int pru = int.Parse(h);
            //pru = (int.Parse(Cantidad.Text) * pru);
            //string nuevoPrueba = pru.ToString();
            //MessageBox.Show(nuevoPrueba);
        }
    }
}
