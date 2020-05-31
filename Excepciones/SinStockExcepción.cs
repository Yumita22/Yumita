using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinStockExcepción : Exception
    {
        public SinStockExcepción() : base("En este momento no hay latas. Disculpe las molestias")
        { }
    }
}
