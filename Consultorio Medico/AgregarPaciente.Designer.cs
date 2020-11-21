namespace Consultorio_Medico
{
    partial class AgregarPaciente
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxNuevoPaciente = new System.Windows.Forms.GroupBox();
            this.lblNombreYapellido = new System.Windows.Forms.Label();
            this.txtBoxNombreYapellido = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxObraSocial = new System.Windows.Forms.TextBox();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.groupBoxNuevoPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNuevoPaciente
            // 
            this.groupBoxNuevoPaciente.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBoxNuevoPaciente.Controls.Add(this.lblNombreYapellido);
            this.groupBoxNuevoPaciente.Controls.Add(this.txtBoxNombreYapellido);
            this.groupBoxNuevoPaciente.Controls.Add(this.btnGuardar);
            this.groupBoxNuevoPaciente.Controls.Add(this.lblDireccion);
            this.groupBoxNuevoPaciente.Controls.Add(this.lblEmail);
            this.groupBoxNuevoPaciente.Controls.Add(this.lblObraSocial);
            this.groupBoxNuevoPaciente.Controls.Add(this.lblTelefono);
            this.groupBoxNuevoPaciente.Controls.Add(this.lblDni);
            this.groupBoxNuevoPaciente.Controls.Add(this.textBoxTelefono);
            this.groupBoxNuevoPaciente.Controls.Add(this.textBoxEmail);
            this.groupBoxNuevoPaciente.Controls.Add(this.textBoxDireccion);
            this.groupBoxNuevoPaciente.Controls.Add(this.textBoxObraSocial);
            this.groupBoxNuevoPaciente.Controls.Add(this.textBoxDni);
            this.groupBoxNuevoPaciente.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBoxNuevoPaciente.Location = new System.Drawing.Point(39, 38);
            this.groupBoxNuevoPaciente.Name = "groupBoxNuevoPaciente";
            this.groupBoxNuevoPaciente.Size = new System.Drawing.Size(855, 705);
            this.groupBoxNuevoPaciente.TabIndex = 5;
            this.groupBoxNuevoPaciente.TabStop = false;
            this.groupBoxNuevoPaciente.Text = "Nuevo paciente";
            // 
            // lblNombreYapellido
            // 
            this.lblNombreYapellido.AutoSize = true;
            this.lblNombreYapellido.Location = new System.Drawing.Point(73, 110);
            this.lblNombreYapellido.Name = "lblNombreYapellido";
            this.lblNombreYapellido.Size = new System.Drawing.Size(134, 20);
            this.lblNombreYapellido.TabIndex = 14;
            this.lblNombreYapellido.Text = "Nombre y apellido";
            // 
            // txtBoxNombreYapellido
            // 
            this.txtBoxNombreYapellido.Location = new System.Drawing.Point(77, 133);
            this.txtBoxNombreYapellido.Name = "txtBoxNombreYapellido";
            this.txtBoxNombreYapellido.Size = new System.Drawing.Size(394, 26);
            this.txtBoxNombreYapellido.TabIndex = 13;
            this.txtBoxNombreYapellido.TextChanged += new System.EventHandler(this.txtBoxNombreYapellido_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(641, 637);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 37);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(73, 574);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(77, 481);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Location = new System.Drawing.Point(73, 296);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(91, 20);
            this.lblObraSocial.TabIndex = 7;
            this.lblObraSocial.Text = "Obra Social";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(73, 387);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 20);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(77, 198);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(45, 20);
            this.lblDni.TabIndex = 5;
            this.lblDni.Text = "D.N.I";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(77, 410);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(394, 26);
            this.textBoxTelefono.TabIndex = 4;
            this.textBoxTelefono.TextChanged += new System.EventHandler(this.textBoxTelefono_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(77, 504);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(394, 26);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(77, 597);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(394, 26);
            this.textBoxDireccion.TabIndex = 2;
            this.textBoxDireccion.TextChanged += new System.EventHandler(this.textBoxDireccion_TextChanged);
            // 
            // textBoxObraSocial
            // 
            this.textBoxObraSocial.Location = new System.Drawing.Point(77, 319);
            this.textBoxObraSocial.Name = "textBoxObraSocial";
            this.textBoxObraSocial.Size = new System.Drawing.Size(394, 26);
            this.textBoxObraSocial.TabIndex = 1;
            this.textBoxObraSocial.TextChanged += new System.EventHandler(this.textBoxObraSocial_TextChanged);
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(77, 221);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(394, 26);
            this.textBoxDni.TabIndex = 0;
            this.textBoxDni.TextChanged += new System.EventHandler(this.textBoxDni_TextChanged);
            // 
            // AgregarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(920, 780);
            this.Controls.Add(this.groupBoxNuevoPaciente);
            this.Name = "AgregarPaciente";
            this.Text = "AgregarPaciente";
            this.groupBoxNuevoPaciente.ResumeLayout(false);
            this.groupBoxNuevoPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxNuevoPaciente;
        private System.Windows.Forms.Label lblNombreYapellido;
        private System.Windows.Forms.TextBox txtBoxNombreYapellido;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxObraSocial;
        private System.Windows.Forms.TextBox textBoxDni;
    }
}