using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Csharp.Clases
{
    public interface Ifunciones
    {
        int Registrar();
        bool Actualizar();
        bool Eliminar();

        DataTable Listar();

        DataTable BuscarPorCodigo( int id);



    }
}
