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

    class CRUD
    {
        MessageBoxButtons buttons = MessageBoxButtons.OK;

        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=consultoriodb; Uid=root; Pwd=''");

        public void Conexion()
        {
            try
            {
                conexion.Open();
                var result = MessageBox.Show("Conexion exitosa", "Bienvenido", buttons);
                conexion.Close();
            }
            catch
            {
                var result = MessageBox.Show("Conexion fallida", "ERROR", buttons);
            }
        }
        // consulta para llenar con todos los datos una listBox , vamos a ir agregando elementos a llenar, (combo y tabla son parametros opcionales por eso estan como null) 
    
        // consulta parametrizada depende de el valor de parametro .
        public DataTable ConsultaParametrizada(String sql, Object parametro = null, String parametro2 = null)
        {
            try
            {
                //Objeto data adapter: realiza conexion y solicitud del usuario.
                MySqlDataAdapter DA = new MySqlDataAdapter(sql, conexion);
                if (parametro != null)
                {
                    DA.SelectCommand.Parameters.AddWithValue("valor", parametro);
                }
                else
                {
                    DA.SelectCommand.Parameters.AddWithValue("valor", parametro2);
                }

                // Data table recibe la informacion del dataAdapter (DA).
                DataTable DT = new DataTable();
                //Pasamos la informacion del dataAdapter (DA) al data (DT) 
                DA.Fill(DT);
                return DT;
            }
            catch
            { 
                MessageBox.Show("No se pudo realizar la consulta");
                return null;
            }
        }
        // funcion que se va usar para hacer abm .
        public void operaciones(String sql)
        {
            //abrimos conexion
            conexion.Open();

            //objeto command almacena las instrucciones  
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            //ejecutamos instruccion
            comando.ExecuteNonQuery();


            //cerramos conexion
            conexion.Close();
        }
        public string ValorEnVariable(String sql)
        {
            string valor;
            //abrimos conexion
            conexion.Open();

            //objeto command almacena las instrucciones  
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            //ejecutamos instruccion
            valor = comando.ExecuteScalar().ToString();


            //cerramos conexion
            conexion.Close();
            return valor;


        }
    }
}
