namespace Examen
{
    partial class RdE
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarEdad = new System.Windows.Forms.Button();
            this.lbPersona = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(90, 78);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(200, 22);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(90, 139);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(200, 22);
            this.tbApellido.TabIndex = 1;
            this.tbApellido.TextChanged += new System.EventHandler(this.tbApellido_TextChanged);
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(90, 198);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(200, 22);
            this.dtpNacimiento.TabIndex = 3;
            this.dtpNacimiento.ValueChanged += new System.EventHandler(this.dtpNacimiento_ValueChanged);
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(90, 276);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(200, 24);
            this.cbCiudad.TabIndex = 4;
            this.cbCiudad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(90, 344);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrarEdad
            // 
            this.btnMostrarEdad.Location = new System.Drawing.Point(90, 395);
            this.btnMostrarEdad.Name = "btnMostrarEdad";
            this.btnMostrarEdad.Size = new System.Drawing.Size(98, 23);
            this.btnMostrarEdad.TabIndex = 6;
            this.btnMostrarEdad.Text = "Mostrar Edad";
            this.btnMostrarEdad.UseVisualStyleBackColor = true;
            this.btnMostrarEdad.Click += new System.EventHandler(this.btnMostrarEdad_Click);
            // 
            // lbPersona
            // 
            this.lbPersona.FormattingEnabled = true;
            this.lbPersona.ItemHeight = 16;
            this.lbPersona.Location = new System.Drawing.Point(512, 87);
            this.lbPersona.Name = "lbPersona";
            this.lbPersona.Size = new System.Drawing.Size(688, 468);
            this.lbPersona.TabIndex = 7;
            // 
            // RdE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 583);
            this.Controls.Add(this.lbPersona);
            this.Controls.Add(this.btnMostrarEdad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Name = "RdE";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarEdad;
        private System.Windows.Forms.ListBox lbPersona;
    }
}

