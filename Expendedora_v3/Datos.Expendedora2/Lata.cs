using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Expendedora2
{
    public class Lata
    {
        private string codigo;
        private string nombre;
        private double precio;
        private double volumen;
        private string sabor;

        public Lata(string codigo, string nombre, double precio, double volumen, string sabor)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.volumen = volumen;
            this.sabor = sabor;

        }
        public string CODIGO { get { return this.codigo; } }
        public string NOMBRE { get { return this.nombre; } }
        public string SABOR { get { return this.sabor; } }
        public double PRECIO { get { return this.precio; } }
        public double VOLUMEN { get { return this.volumen; } }



    }


}

