using Negocios.Expendedora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Datos.Expendedora2;
using Excepciones;

namespace Expendedora_v1
{

    //Problema:
    //Tengo una maquina expendedora y necesito modelar entre otras funciones el agregado y extraccion de latas de bebidas.
    //(Cada caso de uso es un menú en la consola)
    //- caso de uso 0: el usuario enciende la maquina- resultado: maquina encendida.

    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Desea encender la máquina? (S/N)");
            string prender = (Console.ReadLine());
            if (prender == "S")
            {
             
                Menu menu = new Menu();
                menu.Mostrar();
            }
            else if (prender == "N") { Console.WriteLine("La maquiná será apagada"); }
            else { Console.WriteLine("La opción ingresada no es correcta"); }
            Console.Read();
        }

        public static void Listarlatas(Maqexp exp)
        {
            foreach (Lata nuevalata in exp.Latas)
            { Console.WriteLine(nuevalata.ToString()); }
        }

        public static void AgregarLata(Maqexp exp)
        {
            try
            {
                Console.WriteLine("Elija el código de lata a ingresar:\n 1] CO1 - Coca Cola Regular\n2] CO2 - Coca Cola Zero\n3] SP1 - Sprite Regular\n4] SP2 - Sprite Zero\n5] FA1 - Fanta Regular \n6]+ FA2 - Fanta Zero");
                string codigoingresado = Console.ReadLine();
                switch (codigoingresado)
                {
                    case "1":
                        exp.AgregarLata(new Lata("CO1", "Coca Cola Regular", 50.00, 0.5, "Regular"));
                        break;
                    case "2":
                        exp.AgregarLata(new Lata("CO2", "Coca Cola Zero", 50.00, 0.5, "Sin Azúcar"));
                        break;
                    case "3":
                        exp.AgregarLata(new Lata("SP1", "Sprite Regular", 50.00, 0.5, "Regular"));
                        break;
                    case "4":
                        exp.AgregarLata(new Lata("SP2", "Sprite Zero", 50.00, 0.5, "Sin Azúcar"));
                        break;
                    case "5":
                        exp.AgregarLata(new Lata("FA1", "Fanta Regular", 50.00, 0.5, "Regular"));
                        break;
                    case "6":
                        exp.AgregarLata(new Lata("FA2", "Fanta Zero", 50.00, 0.5, "Sin Azúcar"));
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
                Console.WriteLine("Se agregó una Lata");
            }

            catch (CapacidadInsuficienteExcepcion mensaje)
            {
                Console.WriteLine(mensaje.Message);
            }
        }

        public static void ExtraerLata(Maqexp exp)
        {
            try
            {
                Console.WriteLine("Elija el código de lata que desea:\n 1] CO1 - Coca Cola Regular\n2] CO2 - Coca Cola Zero\n3] SP1 - Sprite Regular\n4] SP2 - Sprite Zero\n5] FA1 - Fanta Regular \n6]+ FA2 - Fanta Zero");
                string codigoingresado = Console.ReadLine();
                Console.WriteLine("ingrese el dinero");
                string dineroingresado = Console.ReadLine();
                double dineroingre = Double.Parse(dineroingresado);

                Lata sacar = exp.Extraerlata(codigoingresado, dineroingre);

            }
            //if (dineroingre > sacar.PRECIO)
            //{ Console.WriteLine("Gracias por su compra, retire su lata y el vuelto"); }
            //else if (dineroingre == sacar.PRECIO)
            //{ Console.WriteLine("Gracias por su compra"); }

            catch (DineroInsuficienteExcepcion mensaje)
            {
                Console.WriteLine(mensaje.Message);
            }
            catch (SinStockExcepción mensaje)
            {
                Console.WriteLine(mensaje.Message);
            }

        } 

        public static void ObtenerBalance(Maqexp exp)
        {
            Console.WriteLine(exp.GetBalance());
        }

        public static void MostrarStock(Maqexp exp)
        {
            if (exp.EstaVacia() == true)
            { Console.WriteLine("No hay stock disponible"); }
            else
            { Console.WriteLine("El stock disponible es {0} ", exp.LatasCount()); }
        }
    }
}



    
    





