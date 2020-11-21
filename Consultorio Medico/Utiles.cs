using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Consultorio_Medico
{
    static class Utiles
    {

        public static Boolean validarCampos(string tipoDeDato, string dato)
        {
            #region validaciones
            switch (tipoDeDato)
            {
                case "int":
                    {//telefono

                        try
                        {
                            Convert.ToInt32(dato);
                            return true;
                        }
                        catch (Exception ex)
                        {
                            return false;
                        }

                    }
                case "string":
                    {//direccion
                        try
                        {
                            Convert.ToString(dato);
                            return true;
                        }
                        catch (Exception ex)
                        {
                            return false;
                        }

                    }
                case "long":
                    {//dni

                        try
                        {
                            Convert.ToInt64(dato);
                            return true;
                        }
                        catch
                        {
                            return false;
                        }
                    }
             
                default:
                    {
                        return false;
                    }


            }

            #endregion 

        }
    }
}
