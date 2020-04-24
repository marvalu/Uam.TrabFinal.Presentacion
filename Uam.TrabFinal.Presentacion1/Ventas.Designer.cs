namespace Uam.TrabFinal.Presentacion1
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridEspectaculos = new System.Windows.Forms.DataGridView();
            this.GridCupos = new System.Windows.Forms.DataGridView();
            this.AsientoBajos = new System.Windows.Forms.RadioButton();
            this.AsientoAlto = new System.Windows.Forms.RadioButton();
            this.AsientoMedio = new System.Windows.Forms.RadioButton();
            this.AsientoDiscapacitado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Comprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridEspectaculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCupos)).BeginInit();
            this.SuspendLayout();
            // 
            // GridEspectaculos
            // 
            this.GridEspectaculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEspectaculos.Location = new System.Drawing.Point(62, 30);
            this.GridEspectaculos.Name = "GridEspectaculos";
            this.GridEspectaculos.Size = new System.Drawing.Size(240, 150);
            this.GridEspectaculos.TabIndex = 0;
            this.GridEspectaculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GridCupos
            // 
            this.GridCupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCupos.Location = new System.Drawing.Point(381, 30);
            this.GridCupos.Name = "GridCupos";
            this.GridCupos.Size = new System.Drawing.Size(381, 150);
            this.GridCupos.TabIndex = 1;
            this.GridCupos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCupos_CellContentClick);
            // 
            // AsientoBajos
            // 
            this.AsientoBajos.AutoSize = true;
            this.AsientoBajos.Location = new System.Drawing.Point(91, 282);
            this.AsientoBajos.Name = "AsientoBajos";
            this.AsientoBajos.Size = new System.Drawing.Size(89, 17);
            this.AsientoBajos.TabIndex = 2;
            this.AsientoBajos.TabStop = true;
            this.AsientoBajos.Text = "Asiento Bajos";
            this.AsientoBajos.UseVisualStyleBackColor = true;
            // 
            // AsientoAlto
            // 
            this.AsientoAlto.AutoSize = true;
            this.AsientoAlto.Location = new System.Drawing.Point(233, 282);
            this.AsientoAlto.Name = "AsientoAlto";
            this.AsientoAlto.Size = new System.Drawing.Size(86, 17);
            this.AsientoAlto.TabIndex = 3;
            this.AsientoAlto.TabStop = true;
            this.AsientoAlto.Text = "Asiento Altos";
            this.AsientoAlto.UseVisualStyleBackColor = true;
            // 
            // AsientoMedio
            // 
            this.AsientoMedio.AutoSize = true;
            this.AsientoMedio.Location = new System.Drawing.Point(358, 282);
            this.AsientoMedio.Name = "AsientoMedio";
            this.AsientoMedio.Size = new System.Drawing.Size(102, 17);
            this.AsientoMedio.TabIndex = 4;
            this.AsientoMedio.TabStop = true;
            this.AsientoMedio.Text = "Asientos Medios";
            this.AsientoMedio.UseVisualStyleBackColor = true;
            // 
            // AsientoDiscapacitado
            // 
            this.AsientoDiscapacitado.AutoSize = true;
            this.AsientoDiscapacitado.Location = new System.Drawing.Point(470, 282);
            this.AsientoDiscapacitado.Name = "AsientoDiscapacitado";
            this.AsientoDiscapacitado.Size = new System.Drawing.Size(136, 17);
            this.AsientoDiscapacitado.TabIndex = 5;
            this.AsientoDiscapacitado.TabStop = true;
            this.AsientoDiscapacitado.Text = "Asiento Discapacitados";
            this.AsientoDiscapacitado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad Entradas";
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(284, 362);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(100, 20);
            this.Cantidad.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Eventos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cupos debe señalar el cupo";
            // 
            // Comprar
            // 
            this.Comprar.Location = new System.Drawing.Point(470, 359);
            this.Comprar.Name = "Comprar";
            this.Comprar.Size = new System.Drawing.Size(83, 25);
            this.Comprar.TabIndex = 11;
            this.Comprar.Text = "Comprar";
            this.Comprar.UseVisualStyleBackColor = true;
            this.Comprar.Click += new System.EventHandler(this.Comprar_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Comprar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AsientoDiscapacitado);
            this.Controls.Add(this.AsientoMedio);
            this.Controls.Add(this.AsientoAlto);
            this.Controls.Add(this.AsientoBajos);
            this.Controls.Add(this.GridCupos);
            this.Controls.Add(this.GridEspectaculos);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEspectaculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridEspectaculos;
        private System.Windows.Forms.DataGridView GridCupos;
        private System.Windows.Forms.RadioButton AsientoBajos;
        private System.Windows.Forms.RadioButton AsientoAlto;
        private System.Windows.Forms.RadioButton AsientoMedio;
        private System.Windows.Forms.RadioButton AsientoDiscapacitado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Comprar;
    }
}