using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio_Medico
{
    public partial class AgregarPaciente : Form
    {
        CRUD conection = new CRUD();
        
        Boolean aceptar = false;

        public bool Aceptar { get => aceptar; set => aceptar = value; }

        public AgregarPaciente()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                #region validarDatosIngresados
                String nombreYapellido = txtBoxNombreYapellido.Text;
                String dni = textBoxDni.Text;
                String direccion = textBoxDireccion.Text;
                String obraSocial = textBoxObraSocial.Text;
                String telefono = textBoxTelefono.Text;
                String email = textBoxEmail.Text;

                Boolean validarCampoNombre=Utiles.validarCampos("string", nombreYapellido);
                Boolean validarCampoDireccion = Utiles.validarCampos("string", direccion);
                Boolean validarCampoDni = Utiles.validarCampos("int", dni);
                Boolean validarCampoObraSocial = Utiles.validarCampos("string", obraSocial);
                Boolean validarCampoTelefono = Utiles.validarCampos("long", telefono);
                Boolean validarCampoEmail = Utiles.validarCampos("string", email);
                Boolean banderaCamposVerificados=true;

                if (!validarCampoNombre)
                {
                    txtBoxNombreYapellido.BackColor = System.Drawing.Color.Red;
                    banderaCamposVerificados = false;
                    MessageBox.Show("Revise el campo nombre.", "Error de tipo de dato.");
                }
                else
                {
                    txtBoxNombreYapellido.BackColor = System.Drawing.Color.White;
                }

                if (!validarCampoDni)
                {
                    textBoxDni.BackColor = System.Drawing.Color.Red;
                    banderaCamposVerificados = false;
                    MessageBox.Show("Revise el campo dni.", "Error de tipo de dato.");
                }
                else
                {
                    textBoxDni.BackColor = System.Drawing.Color.White;
                }

                if (!validarCampoDireccion)
                {
                    textBoxDireccion.BackColor = System.Drawing.Color.Red;
                    banderaCamposVerificados = false;
                    MessageBox.Show("Revise el campo direccion.", "Error de tipo de dato.");
                }
                else
                {
                    textBoxDireccion.BackColor = System.Drawing.Color.White;
                }

                if (!validarCampoObraSocial)
                {
                    textBoxObraSocial.BackColor = System.Drawing.Color.Red;
                    banderaCamposVerificados = false;
                    MessageBox.Show("Revise el campo obra social.", "Error de tipo de dato.");
                }
                else
                {
                    textBoxObraSocial.BackColor = System.Drawing.Color.White;
                }

                if (!validarCampoTelefono)
                {
                    textBoxTelefono.BackColor = System.Drawing.Color.Red;
                    banderaCamposVerificados = false;
                    MessageBox.Show("Revise el campo telefono.", "Error de tipo de dato.");
                }
                else
                {
                    textBoxTelefono.BackColor = System.Drawing.Color.White;
                }

                if (!validarCampoEmail)
                {
                    textBoxEmail.BackColor = System.Drawing.Color.Red;
                    banderaCamposVerificados = false;
                    MessageBox.Show("Revise el campo email.", "Error de tipo de dato.");
                }
                else
                {

                    textBoxEmail.BackColor = System.Drawing.Color.White;
                }
                #endregion

                if (banderaCamposVerificados == true)
                {
                    Paciente paciente = new Paciente(nombreYapellido, dni, direccion, obraSocial, telefono, email);
                    paciente.cargarNuevoPacienteDB(paciente);
                    Aceptar = true;
                    this.Close();
                }

            }
            catch(Exception)
            {
                MessageBox.Show("No se pudo cargar el paciente.");
            }


            
            
        }

        #region "Validar btn Guardar"
        private bool validarDatos()
        {
            if (txtBoxNombreYapellido.Text == "" || textBoxDireccion.Text=="" || textBoxDni.Text=="" || textBoxEmail.Text=="" || textBoxObraSocial.Text=="" || textBoxTelefono.Text=="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtBoxNombreYapellido_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = validarDatos();
        }

        private void textBoxDni_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = validarDatos();

        }

        private void textBoxObraSocial_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = validarDatos();
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = validarDatos();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = validarDatos();
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = validarDatos();
        }
        #endregion
    }
}
