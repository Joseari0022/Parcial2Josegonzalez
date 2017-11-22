using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Presupuestos
    {
        [key]
        public int PresupuestosId { get; set; }
        public DateTime Fecha { get; set; }
        public string  Descripcion { get; set; }
        public int Monto { get; set; }
    }
}
