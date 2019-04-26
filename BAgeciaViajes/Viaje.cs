using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAgeciaViajes
{
    public class Viaje
    {
        SqlConnection cn = new SqlConnection(
              ConfigurationManager.ConnectionStrings["cs_proyecto"].ConnectionString
              );

        public DataTable Listar()
        {

            //INSTANCIANDO A LA CLASE DATATABLE
            var tabla = new DataTable();
            //DataTable tabla = new DataTable();
            try
            {
                //CREANDO UNA INSTANCIA DE LA CLASE
                // SQLDATAADAPTER
                using (var adaptador = new SqlDataAdapter("SP_LISTAR_Viajes", cn))
                {
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.Fill(tabla);
                }

            }
            catch (SqlException e)
            {
                Console.Write("Ocurrio un error");
                return tabla;

            }
            return tabla;

        }
    }
}
