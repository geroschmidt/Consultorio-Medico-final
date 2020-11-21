namespace Consultorio_Medico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpboxPacientes = new System.Windows.Forms.GroupBox();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.btnAgregarPaciente = new System.Windows.Forms.Button();
            this.lblBuscarPaciente = new System.Windows.Forms.Label();
            this.textBoxBuscarPaciente = new System.Windows.Forms.TextBox();
            this.groupBoxDatosPaciente = new System.Windows.Forms.GroupBox();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificarDatosPaciente = new System.Windows.Forms.Button();
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
            this.textBoxRegistro = new System.Windows.Forms.TextBox();
            this.gpBoxHC = new System.Windows.Forms.GroupBox();
            this.btnEliminarRegistro = new System.Windows.Forms.Button();
            this.btnModificarDatosRegistro = new System.Windows.Forms.Button();
            this.comboBoxRegistro = new System.Windows.Forms.ComboBox();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.textBoxFechaModificacion = new System.Windows.Forms.TextBox();
            this.gpboxPacientes.SuspendLayout();
            this.groupBoxDatosPaciente.SuspendLayout();
            this.gpBoxHC.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpboxPacientes
            // 
            this.gpboxPacientes.Controls.Add(this.lstPacientes);
            this.gpboxPacientes.Controls.Add(this.btnAgregarPaciente);
            this.gpboxPacientes.Controls.Add(this.lblBuscarPaciente);
            this.gpboxPacientes.Controls.Add(this.textBoxBuscarPaciente);
            this.gpboxPacientes.ForeColor = System.Drawing.SystemColors.InfoText;
            this.gpboxPacientes.Location = new System.Drawing.Point(12, 12);
            this.gpboxPacientes.Name = "gpboxPacientes";
            this.gpboxPacientes.Size = new System.Drawing.Size(466, 705);
            this.gpboxPacientes.TabIndex = 3;
            this.gpboxPacientes.TabStop = false;
            this.gpboxPacientes.Text = "Pacientes";
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 20;
            this.lstPacientes.Location = new System.Drawing.Point(32, 115);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(398, 564);
            this.lstPacientes.TabIndex = 5;
            this.lstPacientes.SelectedValueChanged += new System.EventHandler(this.lstPacientes_SelectedValueChanged);
            // 
            // btnAgregarPaciente
            // 
            this.btnAgregarPaciente.BackColor = System.Drawing.Color.LightGreen;
            this.btnAgregarPaciente.Location = new System.Drawing.Point(268, 46);
            this.btnAgregarPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarPaciente.Name = "btnAgregarPaciente";
            this.btnAgregarPaciente.Size = new System.Drawing.Size(164, 49);
            this.btnAgregarPaciente.TabIndex = 4;
            this.btnAgregarPaciente.Text = "Nuevo Paciente";
            this.btnAgregarPaciente.UseVisualStyleBackColor = false;
            this.btnAgregarPaciente.Click += new System.EventHandler(this.btnAgregarPaciente_Click);
            // 
            // lblBuscarPaciente
            // 
            this.lblBuscarPaciente.AutoSize = true;
            this.lblBuscarPaciente.Location = new System.Drawing.Point(28, 45);
            this.lblBuscarPaciente.Name = "lblBuscarPaciente";
            this.lblBuscarPaciente.Size = new System.Drawing.Size(124, 20);
            this.lblBuscarPaciente.TabIndex = 3;
            this.lblBuscarPaciente.Text = "Buscar paciente";
            // 
            // textBoxBuscarPaciente
            // 
            this.textBoxBuscarPaciente.Location = new System.Drawing.Point(32, 69);
            this.textBoxBuscarPaciente.Name = "textBoxBuscarPaciente";
            this.textBoxBuscarPaciente.ReadOnly = true;
            this.textBoxBuscarPaciente.Size = new System.Drawing.Size(210, 26);
            this.textBoxBuscarPaciente.TabIndex = 2;
            this.textBoxBuscarPaciente.Text = "Ingresar DNI";
            this.textBoxBuscarPaciente.Click += new System.EventHandler(this.textBoxBuscarPaciente_Click);
            this.textBoxBuscarPaciente.TextChanged += new System.EventHandler(this.textBoxBuscarPaciente_TextChanged);
            // 
            // groupBoxDatosPaciente
            // 
            this.groupBoxDatosPaciente.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBoxDatosPaciente.Controls.Add(this.btnEliminarPaciente);
            this.groupBoxDatosPaciente.Controls.Add(this.btnGuardar);
            this.groupBoxDatosPaciente.Controls.Add(this.btnModificarDatosPaciente);
            this.groupBoxDatosPaciente.Controls.Add(this.lblDireccion);
            this.groupBoxDatosPaciente.Controls.Add(this.lblEmail);
            this.groupBoxDatosPaciente.Controls.Add(this.lblObraSocial);
            this.groupBoxDatosPaciente.Controls.Add(this.lblTelefono);
            this.groupBoxDatosPaciente.Controls.Add(this.lblDni);
            this.groupBoxDatosPaciente.Controls.Add(this.textBoxTelefono);
            this.groupBoxDatosPaciente.Controls.Add(this.textBoxEmail);
            this.groupBoxDatosPaciente.Controls.Add(this.textBoxDireccion);
            this.groupBoxDatosPaciente.Controls.Add(this.textBoxObraSocial);
            this.groupBoxDatosPaciente.Controls.Add(this.textBoxDni);
            this.groupBoxDatosPaciente.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBoxDatosPaciente.Location = new System.Drawing.Point(484, 12);
            this.groupBoxDatosPaciente.Name = "groupBoxDatosPaciente";
            this.groupBoxDatosPaciente.Size = new System.Drawing.Size(507, 705);
            this.groupBoxDatosPaciente.TabIndex = 4;
            this.groupBoxDatosPaciente.TabStop = false;
            this.groupBoxDatosPaciente.Text = "Datos paciente";
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarPaciente.Location = new System.Drawing.Point(44, 565);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(135, 63);
            this.btnEliminarPaciente.TabIndex = 12;
            this.btnEliminarPaciente.Text = "Eliminar Paciente";
            this.btnEliminarPaciente.UseVisualStyleBackColor = false;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.btnGuardar.Location = new System.Drawing.Point(328, 565);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 63);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar Datos";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificarDatosPaciente
            // 
            this.btnModificarDatosPaciente.BackColor = System.Drawing.Color.Coral;
            this.btnModificarDatosPaciente.Location = new System.Drawing.Point(184, 565);
            this.btnModificarDatosPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarDatosPaciente.Name = "btnModificarDatosPaciente";
            this.btnModificarDatosPaciente.Size = new System.Drawing.Size(136, 63);
            this.btnModificarDatosPaciente.TabIndex = 10;
            this.btnModificarDatosPaciente.Text = "Modificar Datos";
            this.btnModificarDatosPaciente.UseVisualStyleBackColor = false;
            this.btnModificarDatosPaciente.Click += new System.EventHandler(this.btnModificarDatosPaciente_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(57, 455);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(57, 360);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Location = new System.Drawing.Point(57, 185);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(91, 20);
            this.lblObraSocial.TabIndex = 7;
            this.lblObraSocial.Text = "Obra Social";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(57, 272);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 20);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(60, 92);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(45, 20);
            this.lblDni.TabIndex = 5;
            this.lblDni.Text = "D.N.I";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(56, 295);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.ReadOnly = true;
            this.textBoxTelefono.Size = new System.Drawing.Size(394, 26);
            this.textBoxTelefono.TabIndex = 4;
            this.textBoxTelefono.TextChanged += new System.EventHandler(this.textBoxTelefono_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(56, 383);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(394, 26);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(56, 478);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.ReadOnly = true;
            this.textBoxDireccion.Size = new System.Drawing.Size(394, 26);
            this.textBoxDireccion.TabIndex = 2;
            this.textBoxDireccion.TextChanged += new System.EventHandler(this.textBoxDireccion_TextChanged);
            // 
            // textBoxObraSocial
            // 
            this.textBoxObraSocial.Location = new System.Drawing.Point(56, 208);
            this.textBoxObraSocial.Name = "textBoxObraSocial";
            this.textBoxObraSocial.ReadOnly = true;
            this.textBoxObraSocial.Size = new System.Drawing.Size(394, 26);
            this.textBoxObraSocial.TabIndex = 1;
            this.textBoxObraSocial.TextChanged += new System.EventHandler(this.textBoxObraSocial_TextChanged);
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(56, 115);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.ReadOnly = true;
            this.textBoxDni.Size = new System.Drawing.Size(394, 26);
            this.textBoxDni.TabIndex = 0;
            this.textBoxDni.TextChanged += new System.EventHandler(this.textBoxDni_TextChanged);
            // 
            // textBoxRegistro
            // 
            this.textBoxRegistro.Location = new System.Drawing.Point(36, 115);
            this.textBoxRegistro.Multiline = true;
            this.textBoxRegistro.Name = "textBoxRegistro";
            this.textBoxRegistro.ReadOnly = true;
            this.textBoxRegistro.Size = new System.Drawing.Size(624, 544);
            this.textBoxRegistro.TabIndex = 13;
            this.textBoxRegistro.Click += new System.EventHandler(this.textBoxHC_Click);
            // 
            // gpBoxHC
            // 
            this.gpBoxHC.Controls.Add(this.btnEliminarRegistro);
            this.gpBoxHC.Controls.Add(this.btnModificarDatosRegistro);
            this.gpBoxHC.Controls.Add(this.comboBoxRegistro);
            this.gpBoxHC.Controls.Add(this.btnAgregarRegistro);
            this.gpBoxHC.Controls.Add(this.textBoxFechaModificacion);
            this.gpBoxHC.Controls.Add(this.textBoxRegistro);
            this.gpBoxHC.Location = new System.Drawing.Point(998, 12);
            this.gpBoxHC.Name = "gpBoxHC";
            this.gpBoxHC.Size = new System.Drawing.Size(692, 705);
            this.gpBoxHC.TabIndex = 16;
            this.gpBoxHC.TabStop = false;
            this.gpBoxHC.Text = "Historia Clinica";
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarRegistro.Location = new System.Drawing.Point(266, 669);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(189, 34);
            this.btnEliminarRegistro.TabIndex = 20;
            this.btnEliminarRegistro.Text = "Eliminar Registro";
            this.btnEliminarRegistro.UseVisualStyleBackColor = false;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarHC_Click);
            // 
            // btnModificarDatosRegistro
            // 
            this.btnModificarDatosRegistro.BackColor = System.Drawing.Color.Coral;
            this.btnModificarDatosRegistro.Location = new System.Drawing.Point(460, 669);
            this.btnModificarDatosRegistro.Name = "btnModificarDatosRegistro";
            this.btnModificarDatosRegistro.Size = new System.Drawing.Size(198, 34);
            this.btnModificarDatosRegistro.TabIndex = 19;
            this.btnModificarDatosRegistro.Text = "Modificar Registro";
            this.btnModificarDatosRegistro.UseVisualStyleBackColor = false;
            this.btnModificarDatosRegistro.Click += new System.EventHandler(this.btnModificarDatosHC_Click);
            // 
            // comboBoxRegistro
            // 
            this.comboBoxRegistro.FormattingEnabled = true;
            this.comboBoxRegistro.Location = new System.Drawing.Point(36, 42);
            this.comboBoxRegistro.Name = "comboBoxRegistro";
            this.comboBoxRegistro.Size = new System.Drawing.Size(380, 28);
            this.comboBoxRegistro.TabIndex = 18;
            this.comboBoxRegistro.SelectedIndexChanged += new System.EventHandler(this.comboBoxHC_SelectedIndexChanged);
            this.comboBoxRegistro.SelectedValueChanged += new System.EventHandler(this.comboBoxHC_SelectedValueChanged);
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.BackColor = System.Drawing.Color.LightGreen;
            this.btnAgregarRegistro.Location = new System.Drawing.Point(496, 58);
            this.btnAgregarRegistro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(164, 49);
            this.btnAgregarRegistro.TabIndex = 17;
            this.btnAgregarRegistro.Text = "Nuevo Registro";
            this.btnAgregarRegistro.UseVisualStyleBackColor = false;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // textBoxFechaModificacion
            // 
            this.textBoxFechaModificacion.Enabled = false;
            this.textBoxFechaModificacion.Location = new System.Drawing.Point(36, 82);
            this.textBoxFechaModificacion.Name = "textBoxFechaModificacion";
            this.textBoxFechaModificacion.ReadOnly = true;
            this.textBoxFechaModificacion.Size = new System.Drawing.Size(380, 26);
            this.textBoxFechaModificacion.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1700, 728);
            this.Controls.Add(this.gpBoxHC);
            this.Controls.Add(this.groupBoxDatosPaciente);
            this.Controls.Add(this.gpboxPacientes);
            this.Name = "Form1";
            this.Text = "Consultorio Medico";
            this.gpboxPacientes.ResumeLayout(false);
            this.gpboxPacientes.PerformLayout();
            this.groupBoxDatosPaciente.ResumeLayout(false);
            this.groupBoxDatosPaciente.PerformLayout();
            this.gpBoxHC.ResumeLayout(false);
            this.gpBoxHC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpboxPacientes;
        private System.Windows.Forms.Label lblBuscarPaciente;
        private System.Windows.Forms.TextBox textBoxBuscarPaciente;
        private System.Windows.Forms.GroupBox groupBoxDatosPaciente;
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
        private System.Windows.Forms.Button btnModificarDatosPaciente;
        private System.Windows.Forms.Button btnAgregarPaciente;
        private System.Windows.Forms.TextBox textBoxRegistro;
        private System.Windows.Forms.GroupBox gpBoxHC;
        public  System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.TextBox textBoxFechaModificacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.ComboBox comboBoxRegistro;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.Button btnModificarDatosRegistro;
        private System.Windows.Forms.Button btnEliminarRegistro;
    }
}

