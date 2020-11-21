using System;
using System.Data;
using System.Windows.Forms;

namespace Consultorio_Medico
{
    internal class Registro
    {
        CRUD conection = new CRUD();

        private string fecha;
        private string informacion;
        private string titulo;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Informacion { get => informacion; set => informacion = value; }
        public string Fecha { get => fecha; set => fecha = value; }

        public Registro(string fecha,string informacion,string titulo)
        {
            this.Titulo = titulo;
            this.Informacion = informacion;
            this.Fecha = fecha;
        }
        public Registro(string fecha, string informacion)
        {
            
            this.Informacion = informacion;
            this.Fecha = fecha;
        }
        public Registro()
        {

        }

        public void obtenerRegistroDB(int idHistoriaClinica, int idRegistro)
        {
            try
            {
                //Datos del paciente
                String con = "SELECT * FROM registro WHERE FK_idHistoriaClinica = '" + idHistoriaClinica + "' AND idRegistro = '" + idRegistro + "'";
                //devuelve un array
                DataTable Registro = conection.ConsultaParametrizada(con, idHistoriaClinica);
                this.Fecha = Registro.Rows[0].ItemArray[1].ToString();
                this.Informacion = Registro.Rows[0].ItemArray[2].ToString();
                this.Titulo = Registro.Rows[0].ItemArray[3].ToString();
            }
            catch 
            {

            }

        }
        public void nuevoRegistro(int FKidHC, Registro registro)
        {
            try
            { //fecha,informacion,titulo,FK_idHistoriaClinica
                String consulta2 = "INSERT INTO registro (fecha,informacion,titulo,FK_idHistoriaClinica) VALUES ('" + registro.Fecha + "','" + registro.Informacion + "', '" + registro.Titulo + "', '" +FKidHC+ "')";
                conection.operaciones(consulta2);
                MessageBox.Show("El registro se guardo exitosamente.");
            }
            catch
            {
                MessageBox.Show("No se pudo guardar el nuevo registro.");
            }
        }


         public void eliminarRegistro(int idRegistro)
        {
            try
            {
                String con2 = "DELETE FROM registro WHERE idRegistro = '"+ idRegistro + "'";
            
                conection.operaciones(con2);
                MessageBox.Show("El registro se elimino correctamente.");
            }
            catch
            {
                MessageBox.Show("No se pudo eliminar el registro.");
            }
        }
         public void modificarRegistro(int idRegistro, int idHistoriaClinica, Registro registro)
         {
            try
            {
                //Hacemos update
                String consulta = "UPDATE registro SET fecha = '" + DateTime.Now.Date.ToString("dd/MM/yyyy") + "', informacion = '" + registro.Informacion + "' WHERE FK_idHistoriaClinica = '" + idHistoriaClinica + "' AND idRegistro = '" + idRegistro + "'"; ;
                conection.operaciones(consulta);

                MessageBox.Show("El registro se modificó exitosamente.");
            }
            catch
            {
                MessageBox.Show("No se pudo modificar el registro.");
            }

        }

   
    }


}