using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAgeciaViajes.Entity
{
    public class ViajeEntity
    {
        public int idViaje { get; set; }

        public string origen { get; set; }

        public string destino { get; set; }

        public DateTime fechaSalida { get; set; }

        public DateTime fechaLlegada { get; set; }
    }
}
