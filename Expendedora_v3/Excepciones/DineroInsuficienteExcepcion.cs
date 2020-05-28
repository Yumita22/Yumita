using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DineroInsuficienteExcepcion:Exception
    {
        public DineroInsuficienteExcepcion ():base ("El dinero ingresado no alcanza") 
        {}
    }
}
