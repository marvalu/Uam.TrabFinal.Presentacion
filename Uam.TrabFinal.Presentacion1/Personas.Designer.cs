namespace Uam.TrabFinal.Presentacion1
{
    partial class Personas
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
            this.dataGridPersona = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdAdmin = new System.Windows.Forms.RadioButton();
            this.rdUsr = new System.Windows.Forms.RadioButton();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textCed = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btModifica = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textModificar = new System.Windows.Forms.TextBox();
            this.Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPersona
            // 
            this.dataGridPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersona.Location = new System.Drawing.Point(433, 12);
            this.dataGridPersona.Name = "dataGridPersona";
            this.dataGridPersona.RowHeadersWidth = 51;
            this.dataGridPersona.RowTemplate.Height = 24;
            this.dataGridPersona.Size = new System.Drawing.Size(751, 252);
            this.dataGridPersona.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cedula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // rdAdmin
            // 
            this.rdAdmin.AutoSize = true;
            this.rdAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAdmin.Location = new System.Drawing.Point(23, 287);
            this.rdAdmin.Name = "rdAdmin";
            this.rdAdmin.Size = new System.Drawing.Size(147, 24);
            this.rdAdmin.TabIndex = 5;
            this.rdAdmin.TabStop = true;
            this.rdAdmin.Text = "Administrador";
            this.rdAdmin.UseVisualStyleBackColor = true;
            // 
            // rdUsr
            // 
            this.rdUsr.AutoSize = true;
            this.rdUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdUsr.Location = new System.Drawing.Point(229, 287);
            this.rdUsr.Name = "rdUsr";
            this.rdUsr.Size = new System.Drawing.Size(95, 24);
            this.rdUsr.TabIndex = 6;
            this.rdUsr.TabStop = true;
            this.rdUsr.Text = "Usuario";
            this.rdUsr.UseVisualStyleBackColor = true;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(139, 25);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(185, 22);
            this.textNombre.TabIndex = 7;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(139, 92);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(185, 22);
            this.textApellido.TabIndex = 8;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(139, 216);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(185, 22);
            this.textEmail.TabIndex = 9;
            // 
            // textCed
            // 
            this.textCed.Location = new System.Drawing.Point(139, 158);
            this.textCed.Name = "textCed";
            this.textCed.Size = new System.Drawing.Size(185, 22);
            this.textCed.TabIndex = 10;
            // 
            // btAgregar
            // 
            this.btAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Location = new System.Drawing.Point(386, 289);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(120, 48);
            this.btAgregar.TabIndex = 11;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            // 
            // btModifica
            // 
            this.btModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModifica.Location = new System.Drawing.Point(998, 287);
            this.btModifica.Name = "btModifica";
            this.btModifica.Size = new System.Drawing.Size(120, 50);
            this.btModifica.TabIndex = 12;
            this.btModifica.Text = "Modificar";
            this.btModifica.UseVisualStyleBackColor = true;
            // 
            // Eliminar
            // 
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(549, 289);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(120, 50);
            this.Eliminar.TabIndex = 13;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(689, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Indique el nombre a modificar:";
            // 
            // textModificar
            // 
            this.textModificar.Location = new System.Drawing.Point(754, 326);
            this.textModificar.Name = "textModificar";
            this.textModificar.Size = new System.Drawing.Size(186, 22);
            this.textModificar.TabIndex = 15;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Red;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(1033, 375);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(104, 34);
            this.Salir.TabIndex = 16;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 451);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.textModificar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.btModifica);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.textCed);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.rdUsr);
            this.Controls.Add(this.rdAdmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridPersona);
            this.Name = "Personas";
            this.Text = "Personas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdAdmin;
        private System.Windows.Forms.RadioButton rdUsr;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textCed;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btModifica;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textModificar;
        private System.Windows.Forms.Button Salir;
    }
}