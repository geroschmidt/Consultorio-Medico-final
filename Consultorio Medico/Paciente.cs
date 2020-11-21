using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio_Medico
{
    class Paciente
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost; Database=consultoriodb; Uid=root; Pwd=''");
        CRUD conection = new CRUD();
        private HistoriaClinica HC;
        private String nombreCompleto;
        private String dni;
        private String direccion;
        private String obraSocial;
        private String telefono;
        private String email;
        public Paciente()
        {

        }
        public Paciente(string nombreCompleto, string dni, string direccion, string obraSocial, string telefono, string email)
        {
            this.nombreCompleto = nombreCompleto;
            this.dni = dni;
            this.direccion = direccion;
            this.obraSocial = obraSocial;
            this.telefono = telefono;
            this.email = email;

        }

    

        public string Nombre { get => nombreCompleto; set => nombreCompleto = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string ObraSocial { get => obraSocial; set => obraSocial = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        internal HistoriaClinica HC1 { get => HC; set => HC = value; }

        public void asociarHC(HistoriaClinica HC)
        {
            this.HC1 = HC;
        }


        public void cargarNuevoPacienteDB(Paciente p)
        {
            try
            {
                String consulta = "INSERT INTO paciente (nombreCompleto,dni,direccion,obraSocial,telefono,email) VALUES ('" + p.Nombre + "','" + p.Dni + "','" + p.Direccion + "','" + p.ObraSocial + "','" + p.Telefono + "','" + p.Email + "')";
                conection.operaciones(consulta);
                
                MessageBox.Show("El paciente se agrego correctamente.");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void eliminarPacienteDB(int idPaciente, Paciente p)
        {
            DialogResult r = MessageBox.Show("Esta seguro que desea eliminar el paciente " + p.nombreCompleto + "?.", "ATENCION", MessageBoxButtons.YesNo);
            
            if (r == DialogResult.Yes)
            {
                try
                {
                    
                    //Eliminamos paciente y sus HC
                    String consulta = "DELETE FROM paciente WHERE idPaciente = '" + idPaciente + "'";
                    conection.operaciones(consulta);

                    MessageBox.Show("Se elimino el usuario correctamente.");
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo eliminar el usuario.");
                }

            }
            else
            {

            }
        }

        public void modificarDatosPacienteDB(int idPaciente, Paciente p)
        {
            try
            {
                //Hacemos el update de los campos
                String consulta = "UPDATE paciente SET dni= '" + p.dni + "', direccion= '" + p.direccion + "', obraSocial= '" + p.obraSocial + "',telefono='" + p.telefono + "',email='" + p.email + "' WHERE idPaciente = '" + idPaciente + "'";
                conection.operaciones(consulta);
                MessageBox.Show("Los datos del paciente fueron actualizados.", "Exito");
               
            }
            catch (Exception)
            {
                //No se actualiza
                MessageBox.Show("No se pudo actualizar los datos del paciente.", "ERROR");

            }
        }

        public void obtenerPacienteDB(int idPaciente)
        {
            try
            {
                //Datos del paciente
                String con = "SELECT * FROM paciente WHERE idPaciente = '" + idPaciente + "'";
                //devuelve un array
                DataTable Paciente = conection.ConsultaParametrizada(con, idPaciente);
                this.nombreCompleto = Paciente.Rows[0].ItemArray[1].ToString();
                this.dni = Paciente.Rows[0].ItemArray[2].ToString();
                this.obraSocial = Paciente.Rows[0].ItemArray[4].ToString();
                this.telefono = Paciente.Rows[0].ItemArray[5].ToString();
                this.email = Paciente.Rows[0].ItemArray[6].ToString();
                this.direccion = Paciente.Rows[0].ItemArray[3].ToString();
            }
            catch
            {

            }
            

        }

        public void obtenerPacientePorDNI(int dni, ref MySqlDataAdapter adapter)
        {
            try
            {
                adapter = new MySqlDataAdapter("SELECT * FROM paciente WHERE dni = '" + dni + "'", connection);
            }
            catch
            {

            }
        }

        public void cargarListaPacientes(ref MySqlDataAdapter adapter)
        {
            try
            {
                adapter = new MySqlDataAdapter("SELECT * FROM paciente", connection);
            }
            catch
            {

            }
        }
    }


}
