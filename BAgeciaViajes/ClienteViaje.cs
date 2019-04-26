using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAgeciaViajes
{
    public class ClienteViaje
    {
        SqlConnection cn = new SqlConnection(
              ConfigurationManager.ConnectionStrings["cs_proyecto"].ConnectionString
              );

        

    }
}
