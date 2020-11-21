using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio_Medico
{
    
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost; Database=consultoriodb; Uid=root; Pwd=''");
        MySqlDataAdapter adapter;
        CRUD conexion = new CRUD();
        DataTable table = new DataTable();
        String nombre;
        Registro registro = new Registro();

        public static bool pacienteOk=false;
        public Form1()
        {
            InitializeComponent();
            conexion.Conexion();
            LoadListaPacientes();
        }

        private void textBoxBuscarPaciente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxBuscarPaciente.Text != "" && textBoxBuscarPaciente.Text != null)
                {
                    lstPacientes.DataSource = null;
                    int dni = int.Parse(textBoxBuscarPaciente.Text);
                    
                    Paciente paciente = new Paciente();
                    paciente.obtenerPacientePorDNI(dni,ref adapter);
                    
                    table.Clear();
                    adapter.Fill(table);
                    lstPacientes.DataSource = table;
                    lstPacientes.DisplayMember = "nombreCompleto";
                    lstPacientes.ValueMember = "idPaciente";
                }
                else
                {
                    LoadListaPacientes();
                    
                }
            }
            catch
            {
                
            }
   
        }

        private void textBoxBuscarPaciente_Click(object sender, EventArgs e)
        {
            textBoxBuscarPaciente.ReadOnly = false;
        }

        //Procedimiento para cargar la lista de los pacientes
        private void LoadListaPacientes()
        {
            try
            {
                lstPacientes.DataSource = null;
                Paciente paciente = new Paciente();

                paciente.cargarListaPacientes(ref adapter);
                table.Clear();
                adapter.Fill(table);
                lstPacientes.DataSource = table;
                lstPacientes.DisplayMember = "nombreCompleto";
                lstPacientes.ValueMember = "idPaciente";
                if (lstPacientes.Items.Count == 0)
                {
                    deshabilitarBotones(false);
                }
                else
                {
                    deshabilitarBotones(true);
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        //Procedimiento para mostrar los datos de los pacientes cuando se selecciona en la lista. 
        public void lstPacientes_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                comboBoxRegistro.DataSource = null;
                comboBoxRegistro.Text = "";
                textBoxRegistro.Text = "";

                Paciente paciente = new Paciente();
                int idPaciente = Convert.ToInt32(lstPacientes.SelectedValue);

                paciente.obtenerPacienteDB(idPaciente);

                textBoxDni.Text = paciente.Dni;
                textBoxObraSocial.Text = paciente.ObraSocial;
                textBoxTelefono.Text = paciente.Telefono;
                textBoxEmail.Text = paciente.Email;
                textBoxDireccion.Text = paciente.Direccion;


                //historia clinica
                //Datos del paciente

                HistoriaClinica HC = new HistoriaClinica();
                int existeOno = HC.existeHC(Convert.ToInt32(lstPacientes.SelectedValue));

                if (existeOno == 0)
                {
                    textBoxFechaModificacion.Text = "Sin fecha";
                    textBoxRegistro.Text = "El paciente " + nombre + " no tiene historias clínicas";
                    comboBoxRegistro.Text = null;
                    comboBoxRegistro.Enabled = false;
                }
                
                else
                {
                    comboBoxRegistro.Enabled = true;

                   
                    LlenarComboRegistro();
                 
                }

                //Desabilitamos los campos para que solo se puedan leer y no volver a escribir
                deshabilitarModificaciones();
   }
            catch 
            {
              

            }

            //Si no hay pacientes cargados deshabilitamos botones y limpiamos campos
            if(lstPacientes.DataSource== null)
            {
                
                textBoxDni.Text = "";
                textBoxDireccion.Text = "";
                textBoxTelefono.Text = "";
                textBoxEmail.Text = "";
                textBoxObraSocial.Text = "";
            }
        }

        public void LlenarComboRegistro()
        {
            HistoriaClinica HC = new HistoriaClinica();

            int FK_idHC = HC.traerIDhistoriaClinica(Convert.ToInt32 (lstPacientes.SelectedValue));

            String con2 = "SELECT * FROM registro WHERE FK_idHistoriaClinica = '" + FK_idHC + "'";
            MySqlCommand command = new MySqlCommand(con2, connection);
            MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            mysqldt.Fill(dt);

            comboBoxRegistro.ValueMember = "idRegistro";
            comboBoxRegistro.DisplayMember = "titulo";
            comboBoxRegistro.DataSource = dt;
        }
        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {

            try
            {
                var formularioAgregarPaciente = new AgregarPaciente();

                //Abrimos el formulario para dar de alta a un nuevo paciente
                formularioAgregarPaciente.ShowDialog();

                if (formularioAgregarPaciente.Aceptar == true)
                {
                    LoadListaPacientes();
                }
            }
            catch
            {
                MessageBox.Show("Error al abrir formulario Agregar Paciente.");
            }
            
        }

        private void textBoxHC_Click(object sender, EventArgs e)
        {
            textBoxRegistro.ReadOnly = false;
            
        }

        private void btnModificarDatosPaciente_Click(object sender, EventArgs e)
        {
            //Habilitamos los campos
            textBoxDni.ReadOnly = false;
            textBoxDireccion.ReadOnly = false;
            textBoxObraSocial.ReadOnly = false;
            textBoxTelefono.ReadOnly = false;
            textBoxEmail.ReadOnly = false;

        }

      
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                //Capturamos la id del paciente
                int idPaciente = Convert.ToInt32(lstPacientes.SelectedValue);

                #region validarDatosIngresados
                
                String dni = textBoxDni.Text;
                String direccion = textBoxDireccion.Text;
                String obraSocial = textBoxObraSocial.Text;
                String telefono = textBoxTelefono.Text;
                String email = textBoxEmail.Text;

                Boolean validarCampoDireccion = Utiles.validarCampos("string", direccion);
                Boolean validarCampoDni = Utiles.validarCampos("int", dni);
                Boolean validarCampoObraSocial = Utiles.validarCampos("string", obraSocial);
                Boolean validarCampoTelefono = Utiles.validarCampos("long", telefono);
                Boolean validarCampoEmail = Utiles.validarCampos("string", email);
                Boolean banderaCamposVerificados = true;

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
                

                if (banderaCamposVerificados == true)
                {
                    Paciente paciente = new Paciente(nombre,dni, direccion, obraSocial, telefono, email);

                    paciente.modificarDatosPacienteDB(idPaciente, paciente);
                    
                }

                #endregion
  
            }
            catch(Exception ex)
            {
               
            }
            finally
            {
                //Desabilitamos los campos para que solo se puedan leer y no volver a escribir
                deshabilitarModificaciones();
            }

        }

        private void deshabilitarModificaciones()
        {
            //Desabilitamos los campos para que solo se puedan leer y no volver a escribir
            textBoxDni.ReadOnly = true;
            textBoxDireccion.ReadOnly = true;
            textBoxObraSocial.ReadOnly = true;
            textBoxTelefono.ReadOnly = true;
            textBoxEmail.ReadOnly = true;
        }

        #region validar campos modificados
        private bool validarDatos()
        {
            if (textBoxDni.Text == "" || textBoxDireccion.Text == "" || textBoxObraSocial.Text == "" || textBoxEmail.Text == "" || textBoxTelefono.Text == "")
            {
                btnGuardar.Enabled = false;
                return false;
            }
            else
            {
                btnGuardar.Enabled = true;
                return true;
            }
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
        private void textBoxDni_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = validarDatos();
        }
        #endregion

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {

            try
            {
                Paciente paciente = new Paciente();
                int idPaciente = Convert.ToInt32(lstPacientes.SelectedValue);

                paciente.obtenerPacienteDB(idPaciente);

                paciente.eliminarPacienteDB(idPaciente, paciente);

                LoadListaPacientes();
            }
            catch
            {
                MessageBox.Show("Error al eliminar paciente.","ERROR");
            }

        }

        private void deshabilitarBotones(bool bandera)
        {
            btnGuardar.Enabled = bandera;
            btnEliminarPaciente.Enabled = bandera;
            btnModificarDatosPaciente.Enabled = bandera;
            textBoxRegistro.Enabled = bandera;
            textBoxBuscarPaciente.Enabled = bandera;

        }

        private void comboBoxHC_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                String con2 = "SELECT * FROM registro WHERE idRegistro = '"+comboBoxRegistro.SelectedValue+"'";
                //devuelve un array
              
                DataTable registro = conexion.ConsultaParametrizada(con2, comboBoxRegistro.SelectedValue);
                String info = registro.Rows[0].ItemArray[2].ToString();
                String fecha = registro.Rows[0].ItemArray[1].ToString();
                
                textBoxRegistro.Text = info;
                textBoxFechaModificacion.Text = "";
                textBoxFechaModificacion.Text = "Fecha de creacion: " + fecha;
            }
            catch(Exception ex)
            {
               
            }
           
        }

        private void btnAgregarHC_Click(object sender, EventArgs e)
        {
           
        }

        private void btnModificarDatosHC_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxRegistro.Items.Count ==0)
                {
                    MessageBox.Show("Añada una registro para poder modificarlo.", "Sin registros");
                }
                else
                {
                    if (comboBoxRegistro.SelectedItem == null)
                    {
                        //No tiene HC
                        MessageBox.Show("Seleccione el registro que desea modificar.", "ATENCION");
                        textBoxRegistro.ReadOnly = true;
                    }
                    else
                    {
                        Paciente paciente = new Paciente();
                        int idPaciente = Convert.ToInt32(lstPacientes.SelectedValue);

                        paciente.obtenerPacienteDB(idPaciente);

                        HistoriaClinica HC = new HistoriaClinica();

                        paciente.asociarHC(HC);

                        Registro r = new Registro();

                        //Traemos la id de la hc
                        int FkidHC = HC.traerIDhistoriaClinica(idPaciente);

                        //id del registro
                        int idRegistro = Convert.ToInt32(comboBoxRegistro.SelectedValue);

                        //traemos el registro
                        r.obtenerRegistroDB(FkidHC, idRegistro);
                        r.Informacion = textBoxRegistro.Text;
                       
                        //Agregamos el registro al List
                        paciente.HC1.agregarRegistro(r);
                        
                        //Modificamos el registro
                        paciente.HC1.RegistroHC[0].modificarRegistro(idRegistro,Convert.ToInt32(FkidHC), r);

                        
                        textBoxRegistro.ReadOnly = true;

                    }
                }

            }
            catch
            {
                
                
            }
        }

        private void btnEliminarHC_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxRegistro.Items.Count == 0)
                {
                    MessageBox.Show("No hay registros para eliminar.", "Sin registros");
                }
                else
                {
                    if (comboBoxRegistro.SelectedItem == null)
                    {
                        //No tiene HC
                        MessageBox.Show("Seleccione el registro que desea eliminar.", "ATENCION");
                        textBoxRegistro.ReadOnly = true;
                    }
                    else
                    {
                        Paciente paciente = new Paciente();
                        int idPaciente = Convert.ToInt32(lstPacientes.SelectedValue);

                        paciente.obtenerPacienteDB(idPaciente);

                        HistoriaClinica HC = new HistoriaClinica();

                        paciente.asociarHC(HC);

                        Registro r = new Registro();

                        //Traemos la id de la hc

                        int FkidHC = HC.traerIDhistoriaClinica(idPaciente);

                        //id del registro
                        int idRegistro = Convert.ToInt32(comboBoxRegistro.SelectedValue);

                        //traemos el registro
                        r.obtenerRegistroDB(FkidHC, idRegistro);

                        //Agregamos el registro al List
                        paciente.HC1.agregarRegistro(r);

                        //Eliminamos el registro
                        paciente.HC1.RegistroHC[0].eliminarRegistro(idRegistro);
                        
                        LoadListaPacientes();

                        textBoxRegistro.ReadOnly = true;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                HistoriaClinica HC = new HistoriaClinica();
                int idPaciente = Convert.ToInt32(lstPacientes.SelectedValue);
                int existeOno = HC.existeHC(idPaciente);

                //Comprobamos que el paciente posea HC sino tiene entra al if y le crea una
                if (existeOno == 0)
                {
                    HistoriaClinica historiaClinica = new HistoriaClinica();
                    Paciente paciente = new Paciente();
                    //Asociamos la hc clinica a la BD
                    paciente.asociarHC(historiaClinica);
                    //Subimos la HC a la BD
                    historiaClinica.nuevaHC(idPaciente);
                    
                }

                //si el paciente tiene HC abre el formulario para crear un nuevo registro
                int FkidHC = HC.traerIDhistoriaClinica(idPaciente);

                 var formularioAgregarRegistro = new AgregarRegistro(FkidHC, idPaciente);

                 //Abrimos el formulario para agregar un nuevo registro
                 formularioAgregarRegistro.ShowDialog();
                
                

                LoadListaPacientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxHC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
