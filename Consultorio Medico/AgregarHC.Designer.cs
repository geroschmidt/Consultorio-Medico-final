namespace Consultorio_Medico
{
    partial class AgregarRegistro
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
            this.txtboxInformacionRegistro = new System.Windows.Forms.TextBox();
            this.btnGuardarNuevoRegistro = new System.Windows.Forms.Button();
            this.textBoxTituloRegistro = new System.Windows.Forms.TextBox();
            this.lblTituloRegistro = new System.Windows.Forms.Label();
            this.lblInformacionRegistro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxInformacionRegistro
            // 
            this.txtboxInformacionRegistro.Location = new System.Drawing.Point(100, 215);
            this.txtboxInformacionRegistro.Multiline = true;
            this.txtboxInformacionRegistro.Name = "txtboxInformacionRegistro";
            this.txtboxInformacionRegistro.Size = new System.Drawing.Size(938, 347);
            this.txtboxInformacionRegistro.TabIndex = 0;
            this.txtboxInformacionRegistro.TextChanged += new System.EventHandler(this.txtboxInformacionRegistro_TextChanged);
            // 
            // btnGuardarNuevoRegistro
            // 
            this.btnGuardarNuevoRegistro.BackColor = System.Drawing.Color.LightGreen;
            this.btnGuardarNuevoRegistro.Location = new System.Drawing.Point(866, 602);
            this.btnGuardarNuevoRegistro.Name = "btnGuardarNuevoRegistro";
            this.btnGuardarNuevoRegistro.Size = new System.Drawing.Size(176, 40);
            this.btnGuardarNuevoRegistro.TabIndex = 2;
            this.btnGuardarNuevoRegistro.Text = "Guardar";
            this.btnGuardarNuevoRegistro.UseVisualStyleBackColor = false;
            this.btnGuardarNuevoRegistro.Click += new System.EventHandler(this.btnGuardarNuevaHC_Click);
            // 
            // textBoxTituloRegistro
            // 
            this.textBoxTituloRegistro.Location = new System.Drawing.Point(100, 94);
            this.textBoxTituloRegistro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTituloRegistro.Multiline = true;
            this.textBoxTituloRegistro.Name = "textBoxTituloRegistro";
            this.textBoxTituloRegistro.Size = new System.Drawing.Size(938, 47);
            this.textBoxTituloRegistro.TabIndex = 3;
            this.textBoxTituloRegistro.TextChanged += new System.EventHandler(this.textBoxTituloRegistro_TextChanged);
            // 
            // lblTituloRegistro
            // 
            this.lblTituloRegistro.AutoSize = true;
            this.lblTituloRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRegistro.Location = new System.Drawing.Point(96, 65);
            this.lblTituloRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloRegistro.Name = "lblTituloRegistro";
            this.lblTituloRegistro.Size = new System.Drawing.Size(293, 25);
            this.lblTituloRegistro.TabIndex = 4;
            this.lblTituloRegistro.Text = "Ingrese un titulo para el registro: ";
            // 
            // lblInformacionRegistro
            // 
            this.lblInformacionRegistro.AutoSize = true;
            this.lblInformacionRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacionRegistro.Location = new System.Drawing.Point(96, 188);
            this.lblInformacionRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInformacionRegistro.Name = "lblInformacionRegistro";
            this.lblInformacionRegistro.Size = new System.Drawing.Size(313, 25);
            this.lblInformacionRegistro.TabIndex = 5;
            this.lblInformacionRegistro.Text = "Ingrese la informacion del registro: ";
            // 
            // AgregarRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1148, 672);
            this.Controls.Add(this.lblInformacionRegistro);
            this.Controls.Add(this.lblTituloRegistro);
            this.Controls.Add(this.textBoxTituloRegistro);
            this.Controls.Add(this.btnGuardarNuevoRegistro);
            this.Controls.Add(this.txtboxInformacionRegistro);
            this.Name = "AgregarRegistro";
            this.Text = "Agregar Registro";
            this.Load += new System.EventHandler(this.AgregarHC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxInformacionRegistro;
        private System.Windows.Forms.Button btnGuardarNuevoRegistro;
        private System.Windows.Forms.TextBox textBoxTituloRegistro;
        private System.Windows.Forms.Label lblTituloRegistro;
        private System.Windows.Forms.Label lblInformacionRegistro;
    }
}