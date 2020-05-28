using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Datos.Expendedora2
{
    public class Maqexp
    {
        private List<Lata> _latas = new List<Lata>();
        private bool encendida;
        private double dinero;
        private int capacidad;
        private string proveedor;

        public Maqexp(int Capacidad, string Proveedor)
        {
            this.capacidad = Capacidad;
            this.proveedor = Proveedor;
            _latas.Add(new Lata("CO1", "Coca Cola Regular", 50.00, 0.5, "Regular"));
            _latas.Add(new Lata("CO2", "Coca Cola Zero", 50.00, 0.5, "Sin Azúcar"));
            _latas.Add(new Lata("SP1", "Sprite Regular", 50.00, 0.5, "Regular"));
            _latas.Add(new Lata("SP2", "Sprite Zero", 50.00, 0.5, "Sin Azúcar"));
            _latas.Add(new Lata("FA1", "Fanta Regular", 50.00, 0.5, "Regular"));
            _latas.Add(new Lata("FA2", "Fanta Zero", 50.00, 0.5, "Sin Azúcar"));
        }

        public List<Lata> Latas { get { return this._latas; } }
        public bool Encendida { set { encendida = value; } get { return this.encendida; } }
        public double Dinero { get { return this.dinero; } }

        public bool EstaVacia()
        {
            if (this._latas.Count == 0) { return true; } else { return false; }
        }
        public void EncenderMaquina()
        { encendida = true; }

        public int GetCapacidadRestante()
        { return this.capacidad - this._latas.Count; }
        public int LatasCount()
        { return this._latas.Count; }

        public string GetBalance()
        { return "Cantidad de dinero: " + this.dinero; }

        public void AgregarLata(Lata nuevalata)
        {
            if (GetCapacidadRestante() > 0) { this._latas.Add(nuevalata); }
            else { throw new Exception("Operación invalida"); }
        }
        public Lata Extraerlata(string codigo, double dineroingre)
        {

            Lata sacar = null;
            foreach (Lata remover in this._latas)
            {

                if (dineroingre == remover.PRECIO)
                {
                    this.dinero += remover.PRECIO;
                    sacar = remover;
                    this._latas.Remove(remover);
                    sacar = null;
                    break;
                }
                else if (dineroingre > remover.PRECIO)
                {
                    double vuelto = dineroingre - remover.PRECIO;
                    this.dinero += remover.PRECIO;
                    sacar = remover;
                    this._latas.Remove(remover);
                    break;
                }
                else if (dineroingre < remover.PRECIO) ;
                {
                    throw new DineroInsuficienteExcepcion();
                }
            }
                if (this._latas.Count != 0)
                {
                    return sacar;
                }
                else
                {
                    throw new SinStockExcepción();
                }
        }
            
              
               
            
            
            //Lata sacar = null;
            //foreach (Lata remover in this._latas)
            //{
            //    if (this._latas.Count != 0)
            //    {
            //        if (dineroingre == remover.PRECIO)
            //        {
            //            this.dinero += remover.PRECIO;
            //            sacar = remover;
            //            this._latas.Remove(remover);
            //            sacar = null;
            //            break;
            //        }
            //        else if (dineroingre > remover.PRECIO)
            //        {
            //            double vuelto = dineroingre - remover.PRECIO;
            //            this.dinero += remover.PRECIO;
            //            sacar = remover;
            //            this._latas.Remove(remover);
            //            break;
            //        }
            //        else if (dineroingre < remover.PRECIO) ;
            //        {
            //            throw new DineroInsuficienteExcepcion();
            //        }
            //    }
            //    else
            //    {
            //        throw new SinStockExcepción();
            //    }
            //}
            //return sacar = null;
        }


    }

    


        