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
    public partial class AgregarRegistro : Form
    {
        CRUD conexion = new CRUD();
        

        private int FK_idHC;
        private int idPaciente;
        public AgregarRegistro()
        {
            InitializeComponent();
            
        }

        public AgregarRegistro(int FK_idHC, int idPaciente)
        {
            InitializeComponent();

            this.FK_idHC = FK_idHC;
            this.idPaciente = idPaciente;
        }

        private void btnGuardarNuevaHC_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                Paciente paciente = new Paciente();
                HistoriaClinica hc = new HistoriaClinica();

                Registro registro = new Registro(DateTime.Now.Date.ToString("dd/MM/yyyy"), txtboxInformacionRegistro.Text, textBoxTituloRegistro.Text);
                Console.WriteLine("idPaciente " + idPaciente);
                registro.nuevoRegistro(FK_idHC, registro);

                paciente.asociarHC(hc);
                paciente.HC1.agregarRegistro(registro);
            }
            catch(Exception ex)
            {

            }


            this.Close();
        }

        private void AgregarHC_Load(object sender, EventArgs e)
        {
            this.Size = new Size(800, 500);
            btnGuardarNuevoRegistro.Enabled = false;
        }

        private void textBoxTituloRegistro_TextChanged(object sender, EventArgs e)
        {
            btnGuardarNuevoRegistro.Enabled = verificarCampos();
        }

        private Boolean verificarCampos()
        {
            if((textBoxTituloRegistro.Text!="") && (txtboxInformacionRegistro.Text != ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtboxInformacionRegistro_TextChanged(object sender, EventArgs e)
        {
            btnGuardarNuevoRegistro.Enabled = verificarCampos();
        }
    }
}
