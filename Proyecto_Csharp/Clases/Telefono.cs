using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Csharp.Clases
{
    public class Telefono
    {
        SqlConnection cn = new SqlConnection(
               ConfigurationManager.ConnectionStrings["cs_proyecto"].ConnectionString
               );

        // ESTOS SON LAS PROPIEDADES DE LA CLASE

        public int TelefonoId { get; set; }
        public string    Operador { get; set; }
        public string Numero { get; set; }
        public int EmpleadoId { get; set; }

        public Telefono(string operador, string numero, int empleadoId)
        {
            this.Operador = operador;
            this.Numero = numero;
            this.EmpleadoId = empleadoId;
        }



        public bool Registrar()
        {
            
            try
            {
                using (var cmd = new SqlCommand("SP_REGISTRAR_TELEFONOS", cn))
                {
                    cmd.Parameters.AddWithValue("@OPERADOR", this.Operador);
                    cmd.Parameters.AddWithValue("@NUMERO", this.Numero);
                    cmd.Parameters.AddWithValue("@EMPLEADO_ID", this.EmpleadoId);
                  
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    int r = cmd.ExecuteNonQuery();
                    cn.Close();

                    if (r==1)
                    {
                        return true;
                    }
                }

            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);

                return false;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return false;


        }



    }
}
