using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YLayer.Entidades
{
    [DataContract]
    public class TipoPrestamo
    {
        private string _linea;
        private double _tna;
        
        [DataMember]
        public string Linea
        { set { this._linea = value; } get { return this._linea; }}

        [DataMember]

        public double TNA
        {
            set { this._tna = value; }   get { return this._tna; }
        }

        public override string ToString()
        {
            return this._linea;
        }
    }
}
