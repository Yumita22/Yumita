using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Expendedora
{
    public class CapacidadInsuficienteExcepcion : Exception
    {
        public CapacidadInsuficienteExcepcion() : base("No hay lugar para agregar latas")
            {
            }
    }
}
