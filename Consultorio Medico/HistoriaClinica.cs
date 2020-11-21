using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio_Medico
{
    class HistoriaClinica
    {
        CRUD conection = new CRUD();

        private List<Registro> registroHC = new List<Registro>();

        internal List<Registro> RegistroHC { get => registroHC; }

        public HistoriaClinica()
        {

        }

        public void nuevaHC(int idPaciente)
        {
            try
            {
                String consulta = "INSERT INTO historiaclinica (FK_idPaciente) VALUES ('" + idPaciente + "')";
                conection.operaciones(consulta);
            }
            catch
            {

            }
        }

        public void verificarExistenciaHC(int idPaciente)
        {
            try
            {
                String con3 = "SELECT COUNT(*) FROM historiaclinica WHERE FK_idPaciente = '" + idPaciente + "'";

                String existeOno = conection.ValorEnVariable(con3);

                if (int.Parse(existeOno) == 0)
                {

                    nuevaHC(idPaciente);

                }
            }
            catch
            {

            }
            
        }

        public void agregarRegistro(Registro r) //Implementamos la agregacion
        {
            RegistroHC.Add(r);
        }

        public int traerIDhistoriaClinica(int idPaciente)
        {
            String traerIdHistoriaClinica = "SELECT idHistoriaClinica FROM historiaclinica WHERE FK_idPaciente  = '" + idPaciente + "'";
            String FkidHC = conection.ValorEnVariable(traerIdHistoriaClinica);

            return Convert.ToInt32(FkidHC);
        }

        public int existeHC(int idPaciente)
        {

            String con3 = "SELECT COUNT(*) FROM historiaclinica WHERE FK_idPaciente = '" + idPaciente + "'";
            String existeOno = conection.ValorEnVariable(con3);

            return Convert.ToInt32(existeOno);

        }
    }
}
